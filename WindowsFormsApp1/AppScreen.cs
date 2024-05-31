using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void RecupPersonnel()
        {
            string query = "SELECT * FROM personnel";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();
            lstBox_personnel.Items.Clear();
                while (reader.Read())
            {
                string displayText = $"{reader["nom"]} {reader["prenom"]} - {reader["mail"]} - {reader["tel"]} ";
                lstBox_personnel.Items.Add(displayText);
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

        }
    }
}
