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
        private DataConnection connectionDb;

        public app_login()
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            this.KeyPreview = true; // Ensure the form can receive key press events
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

                return connectionDb.validateLogin(login, hashedPassword);
               
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
