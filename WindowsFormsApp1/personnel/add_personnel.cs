using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class add_personnel : Form
    {
        private DataConnection connectionDb;

        public add_personnel()
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            RecupServices();
        }


        private void RecupServices()
        {
            cbx_idservice.Items.Clear(); 

            cbx_idservice.Items.AddRange(connectionDb.RecupServices().ToArray());

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
            } else
            {

                Service selectedService = (Service)cbx_idservice.SelectedItem;
                int idservice = selectedService.IdService;

                DialogResult result = MessageBox.Show("Do you want to add this worker?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connectionDb.InsertPersonnel(selectedService, nom, prenom, mail, tel, idservice);
                        MessageBox.Show("Personnel added successfully!");
                        ClearFields();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
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
