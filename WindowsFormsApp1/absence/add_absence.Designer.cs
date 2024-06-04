
namespace WindowsFormsApp1
{
    partial class add_absence
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
            this.datedebutPicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btn_add_absence = new System.Windows.Forms.Button();
            this.lbl_datedebut = new System.Windows.Forms.Label();
            this.lbl_datefin = new System.Windows.Forms.Label();
            this.lbl_idPersonnel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_motif = new System.Windows.Forms.Label();
            this.cbx_Motif = new System.Windows.Forms.ComboBox();
            this.input_personnel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datedebutPicker
            // 
            this.datedebutPicker.Location = new System.Drawing.Point(100, 61);
            this.datedebutPicker.Name = "datedebutPicker";
            this.datedebutPicker.Size = new System.Drawing.Size(244, 22);
            this.datedebutPicker.TabIndex = 0;
            this.datedebutPicker.ValueChanged += new System.EventHandler(this.datedebutPicker_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btn_add_absence
            // 
            this.btn_add_absence.Location = new System.Drawing.Point(269, 202);
            this.btn_add_absence.Name = "btn_add_absence";
            this.btn_add_absence.Size = new System.Drawing.Size(75, 33);
            this.btn_add_absence.TabIndex = 2;
            this.btn_add_absence.Text = "Add";
            this.btn_add_absence.UseVisualStyleBackColor = true;
            this.btn_add_absence.Click += new System.EventHandler(this.btn_add_absence_Click_1);
            // 
            // lbl_datedebut
            // 
            this.lbl_datedebut.AutoSize = true;
            this.lbl_datedebut.Location = new System.Drawing.Point(12, 61);
            this.lbl_datedebut.Name = "lbl_datedebut";
            this.lbl_datedebut.Size = new System.Drawing.Size(46, 17);
            this.lbl_datedebut.TabIndex = 3;
            this.lbl_datedebut.Text = "Début";
            // 
            // lbl_datefin
            // 
            this.lbl_datefin.AutoSize = true;
            this.lbl_datefin.Location = new System.Drawing.Point(12, 109);
            this.lbl_datefin.Name = "lbl_datefin";
            this.lbl_datefin.Size = new System.Drawing.Size(27, 17);
            this.lbl_datefin.TabIndex = 4;
            this.lbl_datefin.Text = "Fin";
            // 
            // lbl_idPersonnel
            // 
            this.lbl_idPersonnel.AutoSize = true;
            this.lbl_idPersonnel.Location = new System.Drawing.Point(12, 24);
            this.lbl_idPersonnel.Name = "lbl_idPersonnel";
            this.lbl_idPersonnel.Size = new System.Drawing.Size(72, 17);
            this.lbl_idPersonnel.TabIndex = 5;
            this.lbl_idPersonnel.Text = "Personnel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 6;
            // 
            // lbl_motif
            // 
            this.lbl_motif.AutoSize = true;
            this.lbl_motif.Location = new System.Drawing.Point(12, 159);
            this.lbl_motif.Name = "lbl_motif";
            this.lbl_motif.Size = new System.Drawing.Size(38, 17);
            this.lbl_motif.TabIndex = 8;
            this.lbl_motif.Text = "Motif";
            // 
            // cbx_Motif
            // 
            this.cbx_Motif.FormattingEnabled = true;
            this.cbx_Motif.Location = new System.Drawing.Point(100, 152);
            this.cbx_Motif.Name = "cbx_Motif";
            this.cbx_Motif.Size = new System.Drawing.Size(183, 24);
            this.cbx_Motif.TabIndex = 9;
            // 
            // input_personnel
            // 
            this.input_personnel.Enabled = false;
            this.input_personnel.Location = new System.Drawing.Point(100, 24);
            this.input_personnel.Name = "input_personnel";
            this.input_personnel.Size = new System.Drawing.Size(212, 22);
            this.input_personnel.TabIndex = 10;
            // 
            // add_absence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 257);
            this.Controls.Add(this.input_personnel);
            this.Controls.Add(this.cbx_Motif);
            this.Controls.Add(this.lbl_motif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_idPersonnel);
            this.Controls.Add(this.lbl_datefin);
            this.Controls.Add(this.lbl_datedebut);
            this.Controls.Add(this.btn_add_absence);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.datedebutPicker);
            this.Name = "add_absence";
            this.Text = "add_absence";
            this.Load += new System.EventHandler(this.add_absence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datedebutPicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btn_add_absence;
        private System.Windows.Forms.Label lbl_datedebut;
        private System.Windows.Forms.Label lbl_datefin;
        private System.Windows.Forms.Label lbl_idPersonnel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_motif;
        private System.Windows.Forms.ComboBox cbx_Motif;
        private System.Windows.Forms.TextBox input_personnel;
    }
}