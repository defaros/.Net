namespace Ways.Client._1.Composant_utilisateurs
{
    partial class AidezNousForm
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError2 = new System.Windows.Forms.Label();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelErrorPrenom = new System.Windows.Forms.Label();
            this.labelErrorNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom* :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(99, 105);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(99, 131);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom* :";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(99, 157);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexe :";
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Location = new System.Drawing.Point(99, 183);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(61, 17);
            this.radioButtonH.TabIndex = 7;
            this.radioButtonH.TabStop = true;
            this.radioButtonH.Text = "Homme";
            this.radioButtonH.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(99, 206);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(59, 17);
            this.radioButtonF.TabIndex = 8;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "Femme";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(196, 254);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 9;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(115, 254);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 10;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(520, 128);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(87, 13);
            this.labelError.TabIndex = 15;
            this.labelError.Text = "Email non valide!";
            this.labelError.Visible = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(393, 105);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(327, 20);
            this.textBoxEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Invitez vos amis pour gagner (encore) plus de points!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Les adresses e-mail ne seront pas conservées en base";
            // 
            // labelError2
            // 
            this.labelError2.AutoSize = true;
            this.labelError2.ForeColor = System.Drawing.Color.Red;
            this.labelError2.Location = new System.Drawing.Point(520, 182);
            this.labelError2.Name = "labelError2";
            this.labelError2.Size = new System.Drawing.Size(87, 13);
            this.labelError2.TabIndex = 19;
            this.labelError2.Text = "Email non valide!";
            this.labelError2.Visible = false;
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Location = new System.Drawing.Point(393, 159);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(327, 20);
            this.textBoxEmail2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gagnez des points en nous aidant à mieux vous connaitre!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Les champs marqué d\'un astérisque (*) sont obligatoires";
            // 
            // labelErrorPrenom
            // 
            this.labelErrorPrenom.AutoSize = true;
            this.labelErrorPrenom.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPrenom.Location = new System.Drawing.Point(214, 134);
            this.labelErrorPrenom.Name = "labelErrorPrenom";
            this.labelErrorPrenom.Size = new System.Drawing.Size(82, 13);
            this.labelErrorPrenom.TabIndex = 22;
            this.labelErrorPrenom.Text = "Prénom invalide";
            this.labelErrorPrenom.Visible = false;
            // 
            // labelErrorNom
            // 
            this.labelErrorNom.AutoSize = true;
            this.labelErrorNom.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNom.Location = new System.Drawing.Point(214, 108);
            this.labelErrorNom.Name = "labelErrorNom";
            this.labelErrorNom.Size = new System.Drawing.Size(68, 13);
            this.labelErrorNom.TabIndex = 23;
            this.labelErrorNom.Text = "Nom invalide";
            this.labelErrorNom.Visible = false;
            // 
            // AidezNousForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 290);
            this.Controls.Add(this.labelErrorNom);
            this.Controls.Add(this.labelErrorPrenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelError2);
            this.Controls.Add(this.textBoxEmail2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.Name = "AidezNousForm";
            this.Text = "Aidez Nous à mieux vous connaitre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonH;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelError2;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelErrorPrenom;
        private System.Windows.Forms.Label labelErrorNom;
    }
}