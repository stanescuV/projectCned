
namespace WindowsFormsApp1
{
    partial class add_personnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_personnel));
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_nom = new System.Windows.Forms.TextBox();
            this.input_prenom = new System.Windows.Forms.TextBox();
            this.input_mail = new System.Windows.Forms.TextBox();
            this.input_tel = new System.Windows.Forms.TextBox();
            this.cbx_idservice = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            resources.ApplyResources(this.lbl_nom, "lbl_nom");
            this.lbl_nom.Name = "lbl_nom";
            // 
            // lbl_mail
            // 
            resources.ApplyResources(this.lbl_mail, "lbl_mail");
            this.lbl_mail.Name = "lbl_mail";
            // 
            // lbl_prenom
            // 
            resources.ApplyResources(this.lbl_prenom, "lbl_prenom");
            this.lbl_prenom.Name = "lbl_prenom";
            // 
            // lbl_tel
            // 
            resources.ApplyResources(this.lbl_tel, "lbl_tel");
            this.lbl_tel.Name = "lbl_tel";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // input_nom
            // 
            resources.ApplyResources(this.input_nom, "input_nom");
            this.input_nom.Name = "input_nom";
            // 
            // input_prenom
            // 
            resources.ApplyResources(this.input_prenom, "input_prenom");
            this.input_prenom.Name = "input_prenom";
            // 
            // input_mail
            // 
            resources.ApplyResources(this.input_mail, "input_mail");
            this.input_mail.Name = "input_mail";
            // 
            // input_tel
            // 
            resources.ApplyResources(this.input_tel, "input_tel");
            this.input_tel.Name = "input_tel";
            // 
            // cbx_idservice
            // 
            this.cbx_idservice.FormattingEnabled = true;
            resources.ApplyResources(this.cbx_idservice, "cbx_idservice");
            this.cbx_idservice.Name = "cbx_idservice";
            // 
            // btn_add
            // 
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // add_personnel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbx_idservice);
            this.Controls.Add(this.input_tel);
            this.Controls.Add(this.input_mail);
            this.Controls.Add(this.input_prenom);
            this.Controls.Add(this.input_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.lbl_nom);
            this.Name = "add_personnel";
            this.Load += new System.EventHandler(this.add_personnel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_nom;
        private System.Windows.Forms.TextBox input_prenom;
        private System.Windows.Forms.TextBox input_mail;
        private System.Windows.Forms.TextBox input_tel;
        private System.Windows.Forms.ComboBox cbx_idservice;
        private System.Windows.Forms.Button btn_add;
    }
}