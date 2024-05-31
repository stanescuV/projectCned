using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class app_login : Form
    {
        public static app_login instance;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private readonly string connectionString = "server=localhost;user id=victor;password=qwerty123;persistsecurityinfo=True;database=cned;SslMode=none";

        public app_login()
        {
            InitializeComponent();
            InitConnection();
            this.KeyPreview = true; // Ensure the form can receive key press events
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

        private void app_login_Load(object sender, EventArgs e)
        {

        }

        private bool VerifyLogin(string login, string password)
        {
            // Hash the password
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                string hashedPassword = builder.ToString();

                // Create the SQL query to check the login credentials
                string query = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = @pwd";

                // Execute the query
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@pwd", hashedPassword);

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    // If userCount is greater than 0, the credentials are valid
                    return userCount > 0;
                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string login = input_username.Text; 
            string password = input_password.Text; 

            if (VerifyLogin(login, password))
            {
                app_screen app = new app_screen();
                app.FormClosed += new FormClosedEventHandler(App_FormClosed);
                app.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //on peut appeller la fonction btn_login_click avec un keydown enter
        private void app_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
