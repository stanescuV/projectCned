using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class modify_personnel : Form
    {
        private Personnel selectedPersonnel;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";

        public modify_personnel(Personnel personnel)
        {
            InitializeComponent();
            InitConnection();
            selectedPersonnel = personnel;
            RecupServices(); // Ensure this is called before PopulateFields
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

        private void PopulateFields()
        {
            if (selectedPersonnel != null)
            {
                input_nom.Text = selectedPersonnel.Nom;
                input_prenom.Text = selectedPersonnel.Prenom;
                input_mail.Text = selectedPersonnel.Mail;
                input_tel.Text = selectedPersonnel.Tel;

                foreach (Service service in cbx_idservice.Items)
                {
                    if (service.IdService == selectedPersonnel.IdService)
                    {
                        cbx_idservice.SelectedItem = service;
                        break;
                    }
                }
            }
        }

        private void RecupServices()
        {
            string query = "SELECT idservice, nom FROM service";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Prepare();
            MySqlDataReader reader = command.ExecuteReader();
            cbx_idservice.Items.Clear(); // Clear the ComboBox before populating it

            while (reader.Read())
            {
                Service service = new Service
                {
                    IdService = Convert.ToInt32(reader["idservice"]),
                    Nom = reader["nom"].ToString()
                };
                cbx_idservice.Items.Add(service);
            }
            reader.Close();
            PopulateFields(); // Populate fields after services are loaded
        }

        private void btn_modify_personnel_Click(object sender, EventArgs e)
        {
            string nom = input_nom.Text;
            string prenom = input_prenom.Text;
            string mail = input_mail.Text;
            string tel = input_tel.Text;

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(mail) || string.IsNullOrWhiteSpace(tel) || cbx_idservice.SelectedItem == null)
            {
                MessageBox.Show("Fields are not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Service selectedService = (Service)cbx_idservice.SelectedItem;
            int idservice = selectedService.IdService;

            string query = "UPDATE personnel SET nom = @nom, prenom = @prenom, mail = @mail, tel = @tel, idservice = @idservice WHERE idpersonnel = @idpersonnel";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@nom", nom);
            command.Parameters.AddWithValue("@prenom", prenom);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@idservice", idservice);
            command.Parameters.AddWithValue("@idpersonnel", selectedPersonnel.IdPersonnel);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Personnel updated successfully!");
                this.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void modify_personnel_Load(object sender, EventArgs e)
        {
            // Optionally, move RecupServices() here if you prefer
        }
    }
}
