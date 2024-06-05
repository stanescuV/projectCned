using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class modify_personnel : Form
    {
        private Personnel selectedPersonnel;
        private DataConnection connectionDb;

        public modify_personnel(Personnel personnel)
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            selectedPersonnel = personnel;
            RecupServices(); // Ensure this is called before PopulateFields
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
            cbx_idservice.Items.Clear(); // Clear the ComboBox before populating it
            cbx_idservice.Items.AddRange(connectionDb.RecupServices().ToArray());
            PopulateFields(); // Populate fields after services are loaded
        }

        private void btn_modify_personnel_Click_1(object sender, EventArgs e)
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
            else
            {
                Service selectedService = (Service)cbx_idservice.SelectedItem;
                int idservice = selectedService.IdService;

                DialogResult result = MessageBox.Show("Do you want to update this worker?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        connectionDb.UpdatePersonnel(selectedPersonnel.IdPersonnel, nom, prenom, mail, tel, idservice);
                        MessageBox.Show("Personnel updated successfully!");
                        this.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            
        }

        private void modify_personnel_Load(object sender, EventArgs e)
        {

        }
    }
}
