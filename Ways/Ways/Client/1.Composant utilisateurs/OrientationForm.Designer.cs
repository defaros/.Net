namespace Ways.Client.Composant_utilisateurs
{
    partial class OrientationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDescriptionMetier = new System.Windows.Forms.RichTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.labelSendMail = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vous vous orientez vers...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "labelMetierName";
            // 
            // richTextBoxDescriptionMetier
            // 
            this.richTextBoxDescriptionMetier.Location = new System.Drawing.Point(12, 112);
            this.richTextBoxDescriptionMetier.Name = "richTextBoxDescriptionMetier";
            this.richTextBoxDescriptionMetier.Size = new System.Drawing.Size(568, 96);
            this.richTextBoxDescriptionMetier.TabIndex = 2;
            this.richTextBoxDescriptionMetier.Text = "Description Métier";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(195, 239);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(172, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(242, 265);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(75, 23);
            this.buttonSendMail.TabIndex = 4;
            this.buttonSendMail.Text = "Envoyer";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // labelSendMail
            // 
            this.labelSendMail.AutoSize = true;
            this.labelSendMail.Location = new System.Drawing.Point(180, 223);
            this.labelSendMail.Name = "labelSendMail";
            this.labelSendMail.Size = new System.Drawing.Size(197, 13);
            this.labelSendMail.TabIndex = 5;
            this.labelSendMail.Text = "Envoyer ce rapport dans votre boite mail";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(424, 305);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(156, 23);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retourner au menu principal";
            this.buttonRetour.UseVisualStyleBackColor = true;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Votre adresse e-mail ne sera pas conservée en base";
            // 
            // OrientationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 340);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelSendMail);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.richTextBoxDescriptionMetier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrientationForm";
            this.Text = "Votre métier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionMetier;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Label labelSendMail;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label6;
    }
}