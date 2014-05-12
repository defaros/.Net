using ways.Couche_middleware.Couche_métier._8___Composant_métier;
namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class jeu_result
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mail_contact = new System.Windows.Forms.TextBox();
            this.btn_ajouter_mail = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Terminer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Envoyer le rapport a des amis pour augmenter votre score";
            // 
            // tb_mail_contact
            // 
            this.tb_mail_contact.Location = new System.Drawing.Point(11, 274);
            this.tb_mail_contact.Margin = new System.Windows.Forms.Padding(2);
            this.tb_mail_contact.Name = "tb_mail_contact";
            this.tb_mail_contact.Size = new System.Drawing.Size(192, 20);
            this.tb_mail_contact.TabIndex = 2;
            // 
            // btn_ajouter_mail
            // 
            this.btn_ajouter_mail.Location = new System.Drawing.Point(207, 274);
            this.btn_ajouter_mail.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ajouter_mail.Name = "btn_ajouter_mail";
            this.btn_ajouter_mail.Size = new System.Drawing.Size(81, 20);
            this.btn_ajouter_mail.TabIndex = 3;
            this.btn_ajouter_mail.Text = "Ajouter Email";
            this.btn_ajouter_mail.UseVisualStyleBackColor = true;
            this.btn_ajouter_mail.Click += new System.EventHandler(this.btn_ajouter_mail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Résultat du test d\'orientation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Résultat du jeu :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Points";
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(12, 296);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(71, 13);
            this.lbl_erreur.TabIndex = 8;
            this.lbl_erreur.Text = "Email invalide";
            // 
            // jeu_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.lbl_erreur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ajouter_mail);
            this.Controls.Add(this.tb_mail_contact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "jeu_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Résultats finaux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.jeu_result_FormClosing);
            this.Load += new System.EventHandler(this.jeu_result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mail_contact;
        private System.Windows.Forms.Button btn_ajouter_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_erreur;
    }
}