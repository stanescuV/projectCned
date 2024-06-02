using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class add_personnel : Form
    {
        private MySqlConnection connection;
        private string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";

        public add_personnel()
        {
            InitializeComponent();
            InitConnection();
            RecupServices();
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
        }

        private void ClearFields()
        {
            input_nom.Clear();
            input_prenom.Clear();
            input_mail.Clear();
            input_tel.Clear();
            cbx_idservice.SelectedIndex = -1;
        }

        private void add_personnel_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
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

            DialogResult result = MessageBox.Show("Do you want to add this worker?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Service selectedService = (Service)cbx_idservice.SelectedItem;
                int idservice = selectedService.IdService;

                string query = "INSERT INTO personnel (nom, prenom, mail, tel, idservice) VALUES (@nom, @prenom, @mail, @tel, @idservice)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.Parameters.AddWithValue("@mail", mail);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@idservice", idservice);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Personnel added successfully!");
                    ClearFields();
                    if (app_screen.instance != null)
                    {
                        app_screen.instance.RecupPersonnel();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (app_screen.instance != null)
            {
                app_screen.instance.RecupPersonnel(); // Refresh the ListBox in app_screen when add_personnel form is closed
            }
        }
    }
}
