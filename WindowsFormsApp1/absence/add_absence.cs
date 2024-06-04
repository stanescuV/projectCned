using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class add_absence : Form
    {
        private Personnel selectedPersonnel;
        private DataConnection connectionDb;

        public add_absence(Personnel personnel)
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            selectedPersonnel = personnel;
            input_personnel.Text = $"{selectedPersonnel.Nom} {selectedPersonnel.Prenom}";
            RecupMotifs();
        }

        private void RecupMotifs()
        {
            cbx_Motif.Items.Clear();
            cbx_Motif.DataSource = connectionDb.RecupMotifs();
            cbx_Motif.DisplayMember = "Libelle";
            cbx_Motif.ValueMember = "IdMotif";
        }

        private void add_absence_Load(object sender, EventArgs e)
        {
        }

        private void btn_add_absence_Click_1(object sender, EventArgs e)
        {
            DateTime dateDebut = datedebutPicker.Value;
            DateTime dateFin = dateTimePicker2.Value;
            int idMotif = (int)cbx_Motif.SelectedValue;

            if (dateDebut == null || dateFin == null || idMotif == 0)
            {
                MessageBox.Show("Fields are not completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to add this absence?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    connectionDb.InsertAbsence(selectedPersonnel.IdPersonnel, dateDebut, dateFin, idMotif);
                    MessageBox.Show("Absence added successfully!");
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void datedebutPicker_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
