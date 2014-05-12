namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class edition_contact
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
            this.lbl_mail = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_retour = new System.Windows.Forms.Button();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(8, 15);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(35, 13);
            this.lbl_mail.TabIndex = 2;
            this.lbl_mail.Text = "E-mail";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(63, 12);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.ReadOnly = true;
            this.tb_mail.Size = new System.Drawing.Size(142, 20);
            this.tb_mail.TabIndex = 5;
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(236, 41);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 6;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Visible = false;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(155, 41);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 7;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(74, 41);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 8;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(211, 15);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(65, 13);
            this.lbl_erreur.TabIndex = 9;
            this.lbl_erreur.Text = "Email invalid";
            // 
            // edition_contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 68);
            this.Controls.Add(this.lbl_erreur);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.lbl_mail);
            this.Name = "edition_contact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edition_contact";
            this.Load += new System.EventHandler(this.edition_contact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Label lbl_erreur;
    }
}