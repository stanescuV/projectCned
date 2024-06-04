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
    public partial class modify_absence : Form
    {
        private DataConnection connectionDb;
        private Personnel personnel;
        private Absence absence; 
        public modify_absence(Personnel selectedPersonnel, Absence selectedAbsence)
        {
            InitializeComponent();
            connectionDb = new DataConnection();
            RecupMotifs();
            SetIntitalValues(selectedPersonnel, selectedAbsence);
            personnel = selectedPersonnel;
            absence = selectedAbsence;
        }

        private void RecupMotifs()
        {
            cbx_Motif.Items.Clear();
            cbx_Motif.DataSource = connectionDb.RecupMotifs();
            cbx_Motif.DisplayMember = "Libelle";
            cbx_Motif.ValueMember = "IdMotif";
        }

       private void SetIntitalValues(Personnel selectedPersonnel, Absence selectedAbsence)
        {
            input_personnel.Text = selectedPersonnel.Nom + selectedPersonnel.Prenom;
            datedebutPicker.Value = selectedAbsence.DateDebut;
            datefinPicker.Value = selectedAbsence.DateFin;
            cbx_Motif.SelectedItem = connectionDb.GetTextMotif(selectedAbsence.IdMotif);
        }

        private void modify_absence_Load(object sender, EventArgs e)
        {
        }

        private void btn_modify_absence_Click(object sender, EventArgs e)
        {   
            DateTime dateDebut = datedebutPicker.Value;
            DateTime dateFin = datefinPicker.Value;
            int idMotif = cbx_Motif.SelectedIndex + 1; // je sais que ce n'est pas beau mais je n'ai pas trouvé d'autres idées ici 
            int idAbsence = absence.IdAbsence;
            int idPersonnel = personnel.IdPersonnel;

            connectionDb.UpdateAbsence(idAbsence, idPersonnel, idMotif, dateDebut, dateFin);
            MessageBox.Show("L'absence a été modifié", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
