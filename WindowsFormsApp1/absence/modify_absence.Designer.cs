
namespace WindowsFormsApp1
{
    partial class modify_absence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_personnel = new System.Windows.Forms.TextBox();
            this.cbx_Motif = new System.Windows.Forms.ComboBox();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.lbl_idPersonnel = new System.Windows.Forms.Label();
            this.lbl_datefin = new System.Windows.Forms.Label();
            this.lbl_datedebut = new System.Windows.Forms.Label();
            this.btn_modify_absence = new System.Windows.Forms.Button();
            this.datefinPicker = new System.Windows.Forms.DateTimePicker();
            this.datedebutPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // input_personnel
            // 
            this.input_personnel.Enabled = false;
            this.input_personnel.Location = new System.Drawing.Point(108, 35);
            this.input_personnel.Name = "input_personnel";
            this.input_personnel.Size = new System.Drawing.Size(212, 22);
            this.input_personnel.TabIndex = 19;
            // 
            // cbx_Motif
            // 
            this.cbx_Motif.FormattingEnabled = true;
            this.cbx_Motif.Location = new System.Drawing.Point(108, 163);
            this.cbx_Motif.Name = "cbx_Motif";
            this.cbx_Motif.Size = new System.Drawing.Size(183, 24);
            this.cbx_Motif.TabIndex = 18;
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(20, 170);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(38, 17);
            this.lbl_motif.TabIndex = 17;
            this.lbl_motif.Text = "Motif";
            // 
            // lbl_idPersonnel
            // 
            this.lbl_idPersonnel.AutoSize = true;
            this.lbl_idPersonnel.Location = new System.Drawing.Point(20, 35);
            this.lbl_idPersonnel.Name = "lbl_idPersonnel";
            this.lbl_idPersonnel.Size = new System.Drawing.Size(72, 17);
            this.lbl_idPersonnel.TabIndex = 16;
            this.lbl_idPersonnel.Text = "Personnel";
            // 
            // lbl_datefin
            // 
            this.lbl_datefin.AutoSize = true;
            this.lbl_datefin.Location = new System.Drawing.Point(20, 120);
            this.lbl_datefin.Name = "lbl_datefin";
            this.lbl_datefin.Size = new System.Drawing.Size(27, 17);
            this.lbl_datefin.TabIndex = 15;
            this.lbl_datefin.Text = "Fin";
            // 
            // lbl_datedebut
            // 
            this.lbl_datedebut.AutoSize = true;
            this.lbl_datedebut.Location = new System.Drawing.Point(20, 72);
            this.lbl_datedebut.Name = "lbl_datedebut";
            this.lbl_datedebut.Size = new System.Drawing.Size(46, 17);
            this.lbl_datedebut.TabIndex = 14;
            this.lbl_datedebut.Text = "Début";
            // 
            // btn_modify_absence
            // 
            this.btn_modify_absence.Location = new System.Drawing.Point(277, 213);
            this.btn_modify_absence.Name = "btn_modify_absence";
            this.btn_modify_absence.Size = new System.Drawing.Size(75, 33);
            this.btn_modify_absence.TabIndex = 13;
            this.btn_modify_absence.Text = "Modify";
            this.btn_modify_absence.UseVisualStyleBackColor = true;
            this.btn_modify_absence.Click += new System.EventHandler(this.btn_modify_absence_Click);
            // 
            // datefinPicker
            // 
            this.datefinPicker.Location = new System.Drawing.Point(108, 115);
            this.datefinPicker.Name = "datefinPicker";
            this.datefinPicker.Size = new System.Drawing.Size(244, 22);
            this.datefinPicker.TabIndex = 12;
            // 
            // datedebutPicker
            // 
            this.datedebutPicker.Location = new System.Drawing.Point(108, 72);
            this.datedebutPicker.Name = "datedebutPicker";
            this.datedebutPicker.Size = new System.Drawing.Size(244, 22);
            this.datedebutPicker.TabIndex = 11;
            // 
            // modify_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.input_personnel);
            this.Controls.Add(this.cbx_Motif);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.lbl_idPersonnel);
            this.Controls.Add(this.lbl_datefin);
            this.Controls.Add(this.lbl_datedebut);
            this.Controls.Add(this.btn_modify_absence);
            this.Controls.Add(this.datefinPicker);
            this.Controls.Add(this.datedebutPicker);
            this.Name = "modify_absence";
            this.Text = "modify_absence";
            this.Load += new System.EventHandler(this.modify_absence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_personnel;
        private System.Windows.Forms.ComboBox cbx_Motif;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.Label lbl_idPersonnel;
        private System.Windows.Forms.Label lbl_datefin;
        private System.Windows.Forms.Label lbl_datedebut;
        private System.Windows.Forms.Button btn_modify_absence;
        private System.Windows.Forms.DateTimePicker datefinPicker;
        private System.Windows.Forms.DateTimePicker datedebutPicker;
    }
}