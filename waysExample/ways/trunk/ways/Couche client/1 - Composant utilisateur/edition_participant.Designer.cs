namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class edition_participant
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
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_enregistrer = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_scrore = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.btn_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(201, 32);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 0;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Location = new System.Drawing.Point(282, 32);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_enregistrer.TabIndex = 1;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.UseVisualStyleBackColor = true;
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(8, 9);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(35, 13);
            this.lbl_nom.TabIndex = 2;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_scrore
            // 
            this.lbl_scrore.AutoSize = true;
            this.lbl_scrore.Location = new System.Drawing.Point(155, 9);
            this.lbl_scrore.Name = "lbl_scrore";
            this.lbl_scrore.Size = new System.Drawing.Size(41, 13);
            this.lbl_scrore.TabIndex = 3;
            this.lbl_scrore.Text = "Score :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(49, 6);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 4;
            // 
            // tb_score
            // 
            this.tb_score.Location = new System.Drawing.Point(196, 6);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(100, 20);
            this.tb_score.TabIndex = 5;
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(121, 32);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(74, 23);
            this.btn_retour.TabIndex = 6;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // edition_participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 57);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.lbl_scrore);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_modifier);
            this.Name = "edition_participant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification Nom & Score";
            this.Load += new System.EventHandler(this.edition_participant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_enregistrer;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_scrore;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Button btn_retour;
    }
}