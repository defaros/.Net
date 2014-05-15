namespace Ways.Client.Composant_utilisateurs
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.buttonValider = new System.Windows.Forms.Button();
            this.richTextBoxType = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 188);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 223);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 23);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(96, 258);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(116, 23);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(96, 294);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 23);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValider.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonValider.Location = new System.Drawing.Point(361, 366);
            this.buttonValider.Margin = new System.Windows.Forms.Padding(4);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(100, 34);
            this.buttonValider.TabIndex = 6;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // richTextBoxType
            // 
            this.richTextBoxType.AutoSize = true;
            this.richTextBoxType.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.richTextBoxType.Location = new System.Drawing.Point(289, 42);
            this.richTextBoxType.Name = "richTextBoxType";
            this.richTextBoxType.Size = new System.Drawing.Size(247, 49);
            this.richTextBoxType.TabIndex = 9;
            this.richTextBoxType.Text = "Section Jeu";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.AutoSize = true;
            this.textBoxQuestion.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Underline);
            this.textBoxQuestion.Location = new System.Drawing.Point(43, 129);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(178, 33);
            this.textBoxQuestion.TabIndex = 10;
            this.textBoxQuestion.Text = "La question :";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(819, 428);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.richTextBoxType);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(928, 713);
            this.MinimumSize = new System.Drawing.Size(661, 420);
            this.Name = "GameForm";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label richTextBoxType;
        private System.Windows.Forms.Label textBoxQuestion;
    }
}