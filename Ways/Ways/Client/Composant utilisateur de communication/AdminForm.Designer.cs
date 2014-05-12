namespace Ways.Client.Composant_utilisateur_de_communication
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmail = new System.Windows.Forms.TabPage();
            this.tabPageJeu = new System.Windows.Forms.TabPage();
            this.tabPageOrientation = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCompte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Outil de gestion du programme Ways";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmail);
            this.tabControl1.Controls.Add(this.tabPageJeu);
            this.tabControl1.Controls.Add(this.tabPageOrientation);
            this.tabControl1.Location = new System.Drawing.Point(12, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 188);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageEmail
            // 
            this.tabPageEmail.Controls.Add(this.textBoxPass);
            this.tabPageEmail.Controls.Add(this.label5);
            this.tabPageEmail.Controls.Add(this.textBoxCompte);
            this.tabPageEmail.Controls.Add(this.label4);
            this.tabPageEmail.Controls.Add(this.textBoxPort);
            this.tabPageEmail.Controls.Add(this.label3);
            this.tabPageEmail.Controls.Add(this.textBoxURL);
            this.tabPageEmail.Controls.Add(this.label2);
            this.tabPageEmail.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmail.Name = "tabPageEmail";
            this.tabPageEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmail.Size = new System.Drawing.Size(718, 162);
            this.tabPageEmail.TabIndex = 0;
            this.tabPageEmail.Text = "Email";
            this.tabPageEmail.UseVisualStyleBackColor = true;
            // 
            // tabPageJeu
            // 
            this.tabPageJeu.Location = new System.Drawing.Point(4, 22);
            this.tabPageJeu.Name = "tabPageJeu";
            this.tabPageJeu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJeu.Size = new System.Drawing.Size(718, 162);
            this.tabPageJeu.TabIndex = 1;
            this.tabPageJeu.Text = "Jeu";
            this.tabPageJeu.UseVisualStyleBackColor = true;
            this.tabPageJeu.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPageOrientation
            // 
            this.tabPageOrientation.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrientation.Name = "tabPageOrientation";
            this.tabPageOrientation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrientation.Size = new System.Drawing.Size(718, 162);
            this.tabPageOrientation.TabIndex = 2;
            this.tabPageOrientation.Text = "Orientation";
            this.tabPageOrientation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(85, 26);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(100, 20);
            this.textBoxURL.TabIndex = 1;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(85, 69);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // textBoxCompte
            // 
            this.textBoxCompte.Location = new System.Drawing.Point(341, 26);
            this.textBoxCompte.Name = "textBoxCompte";
            this.textBoxCompte.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompte.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Compte";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(341, 66);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mot de passe";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmail.ResumeLayout(false);
            this.tabPageEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmail;
        private System.Windows.Forms.TabPage tabPageJeu;
        private System.Windows.Forms.TabPage tabPageOrientation;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCompte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label label2;
    }
}