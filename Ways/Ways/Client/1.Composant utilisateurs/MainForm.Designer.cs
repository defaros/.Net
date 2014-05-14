namespace Ways.Client.Composant_utilisateurs
{
    partial class MainForm
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
            this.buttonOrien = new System.Windows.Forms.Button();
            this.buttonJeu = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelHello.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHello.Location = new System.Drawing.Point(367, 34);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(0, 16);
            this.labelHello.TabIndex = 0;
            this.labelHello.Click += new System.EventHandler(this.labelHello_Click);
            // 
            // buttonOrien
            // 
            this.buttonOrien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOrien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrien.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.buttonOrien.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOrien.Location = new System.Drawing.Point(14, 257);
            this.buttonOrien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOrien.Name = "buttonOrien";
            this.buttonOrien.Size = new System.Drawing.Size(225, 39);
            this.buttonOrien.TabIndex = 2;
            this.buttonOrien.Text = "Accès à la section Orientation";
            this.buttonOrien.UseVisualStyleBackColor = false;
            this.buttonOrien.Click += new System.EventHandler(this.buttonOrien_Click);
            // 
            // buttonJeu
            // 
            this.buttonJeu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonJeu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJeu.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.buttonJeu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonJeu.Location = new System.Drawing.Point(341, 257);
            this.buttonJeu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonJeu.Name = "buttonJeu";
            this.buttonJeu.Size = new System.Drawing.Size(179, 39);
            this.buttonJeu.TabIndex = 3;
            this.buttonJeu.Text = "Accès à la section jeu";
            this.buttonJeu.UseVisualStyleBackColor = false;
            this.buttonJeu.Click += new System.EventHandler(this.buttonJeu_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdmin.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdmin.Location = new System.Drawing.Point(621, 257);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(170, 39);
            this.buttonAdmin.TabIndex = 4;
            this.buttonAdmin.Text = "Accès Administrateur";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(360, 156);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(137, 21);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(256, 153);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 24);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Surnom: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 60.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(310, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 106);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Ways";
            this.richTextBox1.BackColorChanged += new System.EventHandler(this.labelHello_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(807, 321);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonJeu);
            this.Controls.Add(this.buttonOrien);
            this.Controls.Add(this.labelHello);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "GameForm";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonOrien;
        private System.Windows.Forms.Button buttonJeu;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}