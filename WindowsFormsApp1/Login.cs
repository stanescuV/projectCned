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
    public partial class app_login : Form
    {
        public static app_login instance;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";
        public app_login()
        {
            InitializeComponent();
            InitConnection();
            //RecupPersonnel();
        }

        private void InitConnection()
        {
            try
            {

            connection = new MySqlConnection(connectionString);
            connection.Open();
            } catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
                
            }
        }
        /*
        private void RecupPersonnel()
        {
            string query = "select * from personnel";
            command = new MySqlCommand(query, connection);
            command.Prepare();
            reader = command.ExecuteReader();
            while (reader.Read())
            {

            }
        }
        */
        private void app_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            app_screen app = new app_screen();
            app.Show();
        }
    }
}
