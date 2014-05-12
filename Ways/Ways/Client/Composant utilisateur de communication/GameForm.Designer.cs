namespace Ways.Client.Composant_utilisateur_de_communication
{
    partial class GameForm
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
            this.labelHello = new System.Windows.Forms.Label();
            this.labelExplications = new System.Windows.Forms.Label();
            this.buttonOrien = new System.Windows.Forms.Button();
            this.buttonJeu = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(326, 32);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(61, 13);
            this.labelHello.TabIndex = 0;
            this.labelHello.Text = "Bienvenue!";
            // 
            // labelExplications
            // 
            this.labelExplications.AutoSize = true;
            this.labelExplications.Location = new System.Drawing.Point(262, 78);
            this.labelExplications.Name = "labelExplications";
            this.labelExplications.Size = new System.Drawing.Size(207, 13);
            this.labelExplications.TabIndex = 1;
            this.labelExplications.Text = "Vous vous trouvez dans la page principale";
            // 
            // buttonOrien
            // 
            this.buttonOrien.Location = new System.Drawing.Point(156, 165);
            this.buttonOrien.Name = "buttonOrien";
            this.buttonOrien.Size = new System.Drawing.Size(75, 56);
            this.buttonOrien.TabIndex = 2;
            this.buttonOrien.Text = "Accès à la section Orientation";
            this.buttonOrien.UseVisualStyleBackColor = true;
            // 
            // buttonJeu
            // 
            this.buttonJeu.Location = new System.Drawing.Point(454, 165);
            this.buttonJeu.Name = "buttonJeu";
            this.buttonJeu.Size = new System.Drawing.Size(75, 56);
            this.buttonJeu.TabIndex = 3;
            this.buttonJeu.Text = "Accès à la section jeu";
            this.buttonJeu.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(550, 12);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(130, 23);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Accès Administrateur";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(268, 124);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Entrez un surnom: ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 261);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonJeu);
            this.Controls.Add(this.buttonOrien);
            this.Controls.Add(this.labelExplications);
            this.Controls.Add(this.labelHello);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelExplications;
        private System.Windows.Forms.Button buttonOrien;
        private System.Windows.Forms.Button buttonJeu;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelName;
    }
}