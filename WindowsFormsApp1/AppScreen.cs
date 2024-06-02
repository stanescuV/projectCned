using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class app_screen : Form
    {
        public static app_screen instance;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";

        public app_screen()
        {
            InitializeComponent();
            instance = this;
            InitConnection();
            RecupPersonnel();
        }

        private void InitConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        public void RecupPersonnel()
        {
            string query = "SELECT idpersonnel, nom, prenom, mail, tel, idservice FROM personnel";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();
            lstBox_personnel.Items.Clear();
            while (reader.Read())
            {
                Personnel personnel = new Personnel
                {
                    IdPersonnel = Convert.ToInt32(reader["idpersonnel"]),
                    Nom = reader["nom"].ToString(),
                    Prenom = reader["prenom"].ToString(),
                    Mail = reader["mail"].ToString(),
                    Tel = reader["tel"].ToString(),
                    IdService = Convert.ToInt32(reader["idservice"]) // Add IdService property
                };
                lstBox_personnel.Items.Add(personnel);
            }
            reader.Close();
        }

        private void app_screen_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_personnel_Click(object sender, EventArgs e)
        {
            add_personnel addP = new add_personnel();
            addP.ShowDialog();
        }

        private void btn_delete_personnel_Click(object sender, EventArgs e)
        {
            if (lstBox_personnel.SelectedItem != null)
            {
                Personnel selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedPersonnel.Nom} {selectedPersonnel.Prenom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Start a transaction
                        using (MySqlTransaction transaction = connection.BeginTransaction())
                        {
                            // Delete from absence table
                            string deleteAbsenceQuery = "DELETE FROM absence WHERE idpersonnel = @idpersonnel";
                            MySqlCommand deleteAbsenceCommand = new MySqlCommand(deleteAbsenceQuery, connection, transaction);
                            deleteAbsenceCommand.Parameters.AddWithValue("@idpersonnel", selectedPersonnel.IdPersonnel);
                            deleteAbsenceCommand.ExecuteNonQuery();

                            // Delete from personnel table
                            string deletePersonnelQuery = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
                            MySqlCommand deletePersonnelCommand = new MySqlCommand(deletePersonnelQuery, connection, transaction);
                            deletePersonnelCommand.Parameters.AddWithValue("@idpersonnel", selectedPersonnel.IdPersonnel);
                            deletePersonnelCommand.ExecuteNonQuery();

                            // Commit the transaction
                            transaction.Commit();
                        }

                        MessageBox.Show("Personnel and related absences deleted successfully!");
                        RecupPersonnel(); // Refresh the list box to remove the deleted personnel
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a personnel to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstBox_personnel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox_personnel.SelectedItem is Personnel selectedPersonnel)
            {
                int idPersonnel = selectedPersonnel.IdPersonnel;
                GetAbsences(idPersonnel);
            }
        }

        private void GetAbsences(int idPersonnel)
        {
            string query = @"
        SELECT a.datedebut, a.datefin, m.libelle 
        FROM absence a
        JOIN motif m ON a.idmotif = m.idmotif
        WHERE a.idpersonnel = @idpersonnel";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idpersonnel", idPersonnel);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    lstBox_absences.Items.Clear(); // Clear previous items before adding new ones
                    while (reader.Read())
                    {
                        string absenceInfo = $"{reader["datedebut"]} - {reader["datefin"]} - {reader["libelle"]}";
                        lstBox_absences.Items.Add(absenceInfo); // Assuming you have a listbox for absences
                    }
                }
            }
        }

        private void btn_modify_personnel_Click(object sender, EventArgs e)
        {
            if (lstBox_personnel.SelectedItem != null)
            {
                Personnel selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
                modify_personnel modifyP = new modify_personnel(selectedPersonnel);
                modifyP.ShowDialog();
                RecupPersonnel(); // Refresh the list after modification
            }
            else
            {
                MessageBox.Show("Please select a personnel to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
