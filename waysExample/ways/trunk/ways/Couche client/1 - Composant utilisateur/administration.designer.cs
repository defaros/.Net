namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class administration
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
            this.bnt_retour = new System.Windows.Forms.Button();
            this.bnt_scores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_list_contacts2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administration";
            // 
            // bnt_retour
            // 
            this.bnt_retour.Location = new System.Drawing.Point(318, 160);
            this.bnt_retour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_retour.Name = "bnt_retour";
            this.bnt_retour.Size = new System.Drawing.Size(145, 31);
            this.bnt_retour.TabIndex = 3;
            this.bnt_retour.Text = "Déconnecter";
            this.bnt_retour.UseVisualStyleBackColor = true;
            this.bnt_retour.Click += new System.EventHandler(this.bnt_retour_Click);
            // 
            // bnt_scores
            // 
            this.bnt_scores.Location = new System.Drawing.Point(15, 53);
            this.bnt_scores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_scores.Name = "bnt_scores";
            this.bnt_scores.Size = new System.Drawing.Size(145, 31);
            this.bnt_scores.TabIndex = 4;
            this.bnt_scores.Text = "Voir les scores";
            this.bnt_scores.UseVisualStyleBackColor = true;
            this.bnt_scores.Click += new System.EventHandler(this.bnt_scores_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ajouter question";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modifier question";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_list_contacts2
            // 
            this.btn_list_contacts2.Location = new System.Drawing.Point(15, 163);
            this.btn_list_contacts2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_list_contacts2.Name = "btn_list_contacts2";
            this.btn_list_contacts2.Size = new System.Drawing.Size(145, 28);
            this.btn_list_contacts2.TabIndex = 12;
            this.btn_list_contacts2.Text = "Editer ";
            this.btn_list_contacts2.UseVisualStyleBackColor = true;
            this.btn_list_contacts2.Click += new System.EventHandler(this.btn_list_contacts2_Click);
            // 
            // administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 204);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_list_contacts2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bnt_scores);
            this.Controls.Add(this.bnt_retour);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administration_FormClosing);
            this.Load += new System.EventHandler(this.admin_questions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnt_retour;
        private System.Windows.Forms.Button bnt_scores;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button btn_list_contacts2;

    }
}