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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelVotreClassement = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelVotreClassement
            // 
            this.labelVotreClassement.AutoSize = true;
            this.labelVotreClassement.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labelVotreClassement.Location = new System.Drawing.Point(12, 262);
            this.labelVotreClassement.Name = "labelVotreClassement";
            this.labelVotreClassement.Size = new System.Drawing.Size(204, 24);
            this.labelVotreClassement.TabIndex = 2;
            this.labelVotreClassement.Text = "Votre Classement :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labelNom.Location = new System.Drawing.Point(258, 300);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(61, 24);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.labelPosition.Location = new System.Drawing.Point(12, 300);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(84, 24);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "Position";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRetour.Location = new System.Drawing.Point(262, 348);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(255, 28);
            this.buttonRetour.TabIndex = 6;
            this.buttonRetour.Text = "Retour au menu Principal";
            this.buttonRetour.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Classement";
            // 
            // textBoxScore
            // 
            this.textBoxScore.AutoSize = true;
            this.textBoxScore.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.textBoxScore.Location = new System.Drawing.Point(593, 300);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(68, 24);
            this.textBoxScore.TabIndex = 11;
            this.textBoxScore.Text = "Score";
            // 
            // ClassementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(710, 398);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelVotreClassement);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClassementForm";
            this.Text = "Classement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVotreClassement;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBoxScore;

    }
}