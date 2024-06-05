using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.exeption;
using WindowsFormsApp1.personnel;

namespace WindowsFormsApp1
{
    public partial class app_screen : Form
    {
        public static app_screen instance;
        private DataConnection connectionDb;
        private Absence selectedAbsence;
        private Personnel selectedPersonnel;

        public app_screen()
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            RecupPersonnel();
            instance = this;
        }

        public void RecupPersonnel()
        {
            lstBox_personnel.Items.Clear();
            lstBox_personnel.Items.AddRange(connectionDb.RecupPersonnel().ToArray());
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
                        connectionDb.DeletePersonnel(selectedPersonnel);
                        MessageBox.Show("Personnel and related absences deleted successfully!");
                        RecupPersonnel(); // Refresh the list box to remove the deleted personnel
                    }
                    catch (DeletionException ex)
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
                selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
                GetAbsences(idPersonnel);
            }
        }

        public void GetAbsences(int idPersonnel)
        {
            lstBox_absences.Items.Clear(); // Clear previous items before adding new ones
            List<Absence> listAbsencesOrdonnee = connectionDb.GetAbsences(idPersonnel).OrderBy(x => x.DateDebut).ToList();
            lstBox_absences.Items.AddRange(listAbsencesOrdonnee.ToArray());
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

        private void btn_add_absence_Click(object sender, EventArgs e)
        {
            if (lstBox_personnel.SelectedItem != null)
            {
                Personnel selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
                add_absence addA = new add_absence(selectedPersonnel);
                addA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a personnel to add an absence.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_modify_absence_Click(object sender, EventArgs e)
        {
            selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
            selectedAbsence = (Absence)lstBox_absences.SelectedItem;
            if (selectedPersonnel is Personnel && selectedAbsence is Absence)
            {
                modify_absence modifyA = new modify_absence(selectedPersonnel, selectedAbsence);
                modifyA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an personnel and an absence to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_delete_absence_Click(object sender, EventArgs e)
        {
                selectedPersonnel = (Personnel)lstBox_personnel.SelectedItem;
                selectedAbsence = (Absence)lstBox_absences.SelectedItem;
                
            if(selectedPersonnel is Personnel && selectedAbsence is Absence)
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the absence of  {selectedPersonnel.Nom} {selectedPersonnel.Prenom}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connectionDb.DeleteAbsence(selectedAbsence);
                    GetAbsences(selectedPersonnel.IdPersonnel);
                    MessageBox.Show("L'absence a été supprimée", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                MessageBox.Show("Please select an absence or a worker", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstBox_absences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox_personnel.SelectedItem is Absence absence)
            {
                selectedAbsence = absence;
            }
        }
    }
}
