
namespace WindowsFormsApp1
{
    partial class app_screen
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
            this.lstBox_personnel = new System.Windows.Forms.ListBox();
            this.lstBox_absences = new System.Windows.Forms.ListBox();
            this.lbl_personnel = new System.Windows.Forms.Label();
            this.lbl_absences = new System.Windows.Forms.Label();
            this.btn_add_personnel = new System.Windows.Forms.Button();
            this.btn_modify_personnel = new System.Windows.Forms.Button();
            this.btn_delete_personnel = new System.Windows.Forms.Button();
            this.btn_delete_absence = new System.Windows.Forms.Button();
            this.btn_modify_absence = new System.Windows.Forms.Button();
            this.btn_add_absence = new System.Windows.Forms.Button();
            this.lbl_selected_personnel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBox_personnel
            // 
            this.lstBox_personnel.FormattingEnabled = true;
            this.lstBox_personnel.ItemHeight = 16;
            this.lstBox_personnel.Location = new System.Drawing.Point(19, 61);
            this.lstBox_personnel.Name = "lstBox_personnel";
            this.lstBox_personnel.Size = new System.Drawing.Size(503, 196);
            this.lstBox_personnel.TabIndex = 0;
            // 
            // lstBox_absences
            // 
            this.lstBox_absences.FormattingEnabled = true;
            this.lstBox_absences.ItemHeight = 16;
            this.lstBox_absences.Location = new System.Drawing.Point(19, 325);
            this.lstBox_absences.Name = "lstBox_absences";
            this.lstBox_absences.Size = new System.Drawing.Size(503, 196);
            this.lstBox_absences.TabIndex = 1;
            // 
            // lbl_personnel
            // 
            this.lbl_personnel.AutoSize = true;
            this.lbl_personnel.Location = new System.Drawing.Point(16, 23);
            this.lbl_personnel.Name = "lbl_personnel";
            this.lbl_personnel.Size = new System.Drawing.Size(72, 17);
            this.lbl_personnel.TabIndex = 2;
            this.lbl_personnel.Text = "Personnel";
            // 
            // lbl_absences
            // 
            this.lbl_absences.AutoSize = true;
            this.lbl_absences.Location = new System.Drawing.Point(18, 289);
            this.lbl_absences.Name = "lbl_absences";
            this.lbl_absences.Size = new System.Drawing.Size(70, 17);
            this.lbl_absences.TabIndex = 3;
            this.lbl_absences.Text = "Absences";
            // 
            // btn_add_personnel
            // 
            this.btn_add_personnel.Location = new System.Drawing.Point(538, 62);
            this.btn_add_personnel.Name = "btn_add_personnel";
            this.btn_add_personnel.Size = new System.Drawing.Size(106, 34);
            this.btn_add_personnel.TabIndex = 4;
            this.btn_add_personnel.Text = "Add";
            this.btn_add_personnel.UseVisualStyleBackColor = true;
            this.btn_add_personnel.Click += new System.EventHandler(this.btn_add_personnel_Click);
            // 
            // btn_modify_personnel
            // 
            this.btn_modify_personnel.Location = new System.Drawing.Point(538, 102);
            this.btn_modify_personnel.Name = "btn_modify_personnel";
            this.btn_modify_personnel.Size = new System.Drawing.Size(106, 34);
            this.btn_modify_personnel.TabIndex = 5;
            this.btn_modify_personnel.Text = "Modify";
            this.btn_modify_personnel.UseVisualStyleBackColor = true;
            // 
            // btn_delete_personnel
            // 
            this.btn_delete_personnel.Location = new System.Drawing.Point(538, 142);
            this.btn_delete_personnel.Name = "btn_delete_personnel";
            this.btn_delete_personnel.Size = new System.Drawing.Size(106, 34);
            this.btn_delete_personnel.TabIndex = 6;
            this.btn_delete_personnel.Text = "Delete";
            this.btn_delete_personnel.UseVisualStyleBackColor = true;
            this.btn_delete_personnel.Click += new System.EventHandler(this.btn_delete_personnel_Click);
            // 
            // btn_delete_absence
            // 
            this.btn_delete_absence.Location = new System.Drawing.Point(538, 402);
            this.btn_delete_absence.Name = "btn_delete_absence";
            this.btn_delete_absence.Size = new System.Drawing.Size(106, 35);
            this.btn_delete_absence.TabIndex = 9;
            this.btn_delete_absence.Text = "Delete";
            this.btn_delete_absence.UseVisualStyleBackColor = true;
            // 
            // btn_modify_absence
            // 
            this.btn_modify_absence.Location = new System.Drawing.Point(538, 362);
            this.btn_modify_absence.Name = "btn_modify_absence";
            this.btn_modify_absence.Size = new System.Drawing.Size(106, 35);
            this.btn_modify_absence.TabIndex = 8;
            this.btn_modify_absence.Text = "Modify";
            this.btn_modify_absence.UseVisualStyleBackColor = true;
            // 
            // btn_add_absence
            // 
            this.btn_add_absence.Location = new System.Drawing.Point(538, 322);
            this.btn_add_absence.Name = "btn_add_absence";
            this.btn_add_absence.Size = new System.Drawing.Size(106, 35);
            this.btn_add_absence.TabIndex = 7;
            this.btn_add_absence.Text = "Add";
            this.btn_add_absence.UseVisualStyleBackColor = true;
            // 
            // lbl_selected_personnel
            // 
            this.lbl_selected_personnel.AutoSize = true;
            this.lbl_selected_personnel.Location = new System.Drawing.Point(109, 289);
            this.lbl_selected_personnel.Name = "lbl_selected_personnel";
            this.lbl_selected_personnel.Size = new System.Drawing.Size(0, 17);
            this.lbl_selected_personnel.TabIndex = 10;
            // 
            // app_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 533);
            this.Controls.Add(this.lbl_selected_personnel);
            this.Controls.Add(this.btn_delete_absence);
            this.Controls.Add(this.btn_modify_absence);
            this.Controls.Add(this.btn_add_absence);
            this.Controls.Add(this.btn_delete_personnel);
            this.Controls.Add(this.btn_modify_personnel);
            this.Controls.Add(this.btn_add_personnel);
            this.Controls.Add(this.lbl_absences);
            this.Controls.Add(this.lbl_personnel);
            this.Controls.Add(this.lstBox_absences);
            this.Controls.Add(this.lstBox_personnel);
            this.Name = "app_screen";
            this.Text = "Gestionnaire d\'absences";
            this.Load += new System.EventHandler(this.app_screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_personnel;
        private System.Windows.Forms.ListBox lstBox_absences;
        private System.Windows.Forms.Label lbl_personnel;
        private System.Windows.Forms.Label lbl_absences;
        private System.Windows.Forms.Button btn_add_personnel;
        private System.Windows.Forms.Button btn_modify_personnel;
        private System.Windows.Forms.Button btn_delete_personnel;
        private System.Windows.Forms.Button btn_delete_absence;
        private System.Windows.Forms.Button btn_modify_absence;
        private System.Windows.Forms.Button btn_add_absence;
        private System.Windows.Forms.Label lbl_selected_personnel;
    }
}