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
            this.labelMetierName = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.25F);
            this.label1.Location = new System.Drawing.Point(295, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre filière";
            // 
            // labelMetierName
            // 
            this.labelMetierName.AutoSize = true;
            this.labelMetierName.Font = new System.Drawing.Font("Century Gothic", 18.25F);
            this.labelMetierName.Location = new System.Drawing.Point(298, 112);
            this.labelMetierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMetierName.Name = "labelMetierName";
            this.labelMetierName.Size = new System.Drawing.Size(230, 31);
            this.labelMetierName.TabIndex = 1;
            this.labelMetierName.Text = "labelMetierName";
            // 
            // richTextBoxDescriptionMetier
            // 
            this.richTextBoxDescriptionMetier.Location = new System.Drawing.Point(16, 163);
            this.richTextBoxDescriptionMetier.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxDescriptionMetier.Name = "richTextBoxDescriptionMetier";
            this.richTextBoxDescriptionMetier.Size = new System.Drawing.Size(756, 138);
            this.richTextBoxDescriptionMetier.TabIndex = 2;
            this.richTextBoxDescriptionMetier.Text = "Description Métier";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(260, 350);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(228, 24);
            this.textBoxEmail.TabIndex = 3;
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSendMail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSendMail.Location = new System.Drawing.Point(323, 388);
            this.buttonSendMail.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(100, 34);
            this.buttonSendMail.TabIndex = 4;
            this.buttonSendMail.Text = "Envoyer";
            this.buttonSendMail.UseVisualStyleBackColor = false;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // labelSendMail
            // 
            this.labelSendMail.AutoSize = true;
            this.labelSendMail.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labelSendMail.Location = new System.Drawing.Point(167, 322);
            this.labelSendMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSendMail.Name = "labelSendMail";
            this.labelSendMail.Size = new System.Drawing.Size(429, 24);
            this.labelSendMail.TabIndex = 5;
            this.labelSendMail.Text = "Envoyer ce rapport dans votre boite mail";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRetour.Location = new System.Drawing.Point(554, 446);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(219, 34);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retourner au menu principal";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 465);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Votre adresse e-mail ne sera pas conservée en base";
            // 
            // OrientationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(789, 497);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelSendMail);
            this.Controls.Add(this.buttonSendMail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.richTextBoxDescriptionMetier);
            this.Controls.Add(this.labelMetierName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrientationForm";
            this.Text = "Votre métier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMetierName;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionMetier;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Label labelSendMail;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label label6;
    }
}