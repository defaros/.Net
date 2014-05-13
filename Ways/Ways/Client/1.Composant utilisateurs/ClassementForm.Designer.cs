namespace Ways.Client.Composant_utilisateurs
{
    partial class ClassementForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelClassement = new System.Windows.Forms.Label();
            this.labelVotreClassement = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelClassement
            // 
            this.labelClassement.AutoSize = true;
            this.labelClassement.Location = new System.Drawing.Point(280, 9);
            this.labelClassement.Name = "labelClassement";
            this.labelClassement.Size = new System.Drawing.Size(61, 13);
            this.labelClassement.TabIndex = 1;
            this.labelClassement.Text = "Classement";
            // 
            // labelVotreClassement
            // 
            this.labelVotreClassement.AutoSize = true;
            this.labelVotreClassement.Location = new System.Drawing.Point(13, 211);
            this.labelVotreClassement.Name = "labelVotreClassement";
            this.labelVotreClassement.Size = new System.Drawing.Size(95, 13);
            this.labelVotreClassement.TabIndex = 2;
            this.labelVotreClassement.Text = "Votre Classement :";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(497, 235);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 3;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(139, 242);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(13, 242);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position";
            // 
            // buttonRetour
            // 
            this.buttonRetour.Location = new System.Drawing.Point(225, 288);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(147, 23);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour au menu Principal";
            this.buttonRetour.UseVisualStyleBackColor = true;
            // 
            // ClassementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 323);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelVotreClassement);
            this.Controls.Add(this.labelClassement);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClassementForm";
            this.Text = "ClassementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelClassement;
        private System.Windows.Forms.Label labelVotreClassement;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonRetour;

    }
}