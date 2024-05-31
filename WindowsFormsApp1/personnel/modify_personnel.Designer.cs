
namespace WindowsFormsApp1
{
    partial class modify_personnel
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
            this.btn_modify_personnel = new System.Windows.Forms.Button();
            this.cbx_idservice = new System.Windows.Forms.ComboBox();
            this.input_tel = new System.Windows.Forms.TextBox();
            this.input_mail = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.lbl_idservice = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_modify_personnel
            // 
            this.btn_modify_personnel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_modify_personnel.Location = new System.Drawing.Point(187, 230);
            this.btn_modify_personnel.Name = "btn_modify_personnel";
            this.btn_modify_personnel.Size = new System.Drawing.Size(75, 41);
            this.btn_modify_personnel.TabIndex = 21;
            this.btn_modify_personnel.Text = "Modify";
            this.btn_modify_personnel.UseVisualStyleBackColor = true;
            // 
            // cbx_idservice
            // 
            this.cbx_idservice.FormattingEnabled = true;
            this.cbx_idservice.Location = new System.Drawing.Point(77, 174);
            this.cbx_idservice.Name = "cbx_idservice";
            this.cbx_idservice.Size = new System.Drawing.Size(187, 24);
            this.cbx_idservice.TabIndex = 20;
            // 
            // input_tel
            // 
            this.input_tel.Location = new System.Drawing.Point(77, 129);
            this.input_tel.Name = "input_tel";
            this.input_tel.Size = new System.Drawing.Size(185, 22);
            this.input_tel.TabIndex = 19;
            // 
            // input_mail
            // 
            this.input_mail.Location = new System.Drawing.Point(77, 93);
            this.input_mail.Name = "input_mail";
            this.input_mail.Size = new System.Drawing.Size(185, 22);
            this.input_mail.TabIndex = 18;
            // 
            // input_prenom
            // 
            this.input_prenom.Location = new System.Drawing.Point(77, 54);
            this.input_prenom.Name = "input_prenom";
            this.input_prenom.Size = new System.Drawing.Size(185, 22);
            this.input_prenom.TabIndex = 17;
            // 
            // input_nom
            // 
            this.input_nom.Location = new System.Drawing.Point(77, 20);
            this.input_nom.Name = "input_nom";
            this.input_nom.Size = new System.Drawing.Size(185, 22);
            this.input_nom.TabIndex = 16;
            // 
            // lbl_idservice
            // 
            this.lbl_idservice.AutoSize = true;
            this.lbl_idservice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_idservice.Location = new System.Drawing.Point(7, 174);
            this.lbl_idservice.Name = "lbl_idservice";
            this.lbl_idservice.Size = new System.Drawing.Size(64, 17);
            this.lbl_idservice.TabIndex = 15;
            this.lbl_idservice.Text = "idservice";
            this.lbl_idservice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_tel.Location = new System.Drawing.Point(7, 129);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(23, 17);
            this.lbl_tel.TabIndex = 14;
            this.lbl_tel.Text = "tel";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_prenom.Location = new System.Drawing.Point(7, 54);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(56, 17);
            this.lbl_prenom.TabIndex = 13;
            this.lbl_prenom.Text = "prenom";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_mail.Location = new System.Drawing.Point(7, 93);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(33, 17);
            this.lbl_mail.TabIndex = 12;
            this.lbl_mail.Text = "mail";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nom.Location = new System.Drawing.Point(7, 20);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 17);
            this.lbl_nom.TabIndex = 11;
            this.lbl_nom.Text = "nom";
            // 
            // modify_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 290);
            this.Controls.Add(this.btn_modify_personnel);
            this.Controls.Add(this.cbx_idservice);
            this.Controls.Add(this.input_tel);
            this.Controls.Add(this.input_mail);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.lbl_idservice);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_nom);
            this.Name = "modify_personnel";
            this.Text = "modify_personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modify_personnel;
        private System.Windows.Forms.ComboBox cbx_idservice;
        private System.Windows.Forms.TextBox input_tel;
        private System.Windows.Forms.TextBox input_mail;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.Label lbl_idservice;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_nom;
    }
}