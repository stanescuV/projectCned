
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox_personnel
            // 
            this.lstBox_personnel.FormattingEnabled = true;
            this.lstBox_personnel.ItemHeight = 16;
            this.lstBox_personnel.Location = new System.Drawing.Point(19, 61);
            this.lstBox_personnel.Name = "lstBox_personnel";
            this.lstBox_personnel.Size = new System.Drawing.Size(322, 196);
            this.lstBox_personnel.TabIndex = 0;
            // 
            // lstBox_absences
            // 
            this.lstBox_absences.FormattingEnabled = true;
            this.lstBox_absences.ItemHeight = 16;
            this.lstBox_absences.Location = new System.Drawing.Point(12, 325);
            this.lstBox_absences.Name = "lstBox_absences";
            this.lstBox_absences.Size = new System.Drawing.Size(329, 196);
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
            this.lbl_absences.Location = new System.Drawing.Point(9, 287);
            this.lbl_absences.Name = "lbl_absences";
            this.lbl_absences.Size = new System.Drawing.Size(70, 17);
            this.lbl_absences.TabIndex = 3;
            this.lbl_absences.Text = "Absences";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(347, 365);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 34);
            this.button5.TabIndex = 8;
            this.button5.Text = "Modify";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(347, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // app_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 533);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_absences);
            this.Controls.Add(this.lbl_personnel);
            this.Controls.Add(this.lstBox_absences);
            this.Controls.Add(this.lstBox_personnel);
            this.Name = "app_screen";
            this.Text = "Gestionnaire d\'absences";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_personnel;
        private System.Windows.Forms.ListBox lstBox_absences;
        private System.Windows.Forms.Label lbl_personnel;
        private System.Windows.Forms.Label lbl_absences;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}