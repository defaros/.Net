namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class mode_edition
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
            this.btn_edition_list_contact = new System.Windows.Forms.Button();
            this.btn_edition_liste_participants = new System.Windows.Forms.Button();
            this.btn_reteour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_edition_list_contact
            // 
            this.btn_edition_list_contact.Location = new System.Drawing.Point(171, 93);
            this.btn_edition_list_contact.Name = "btn_edition_list_contact";
            this.btn_edition_list_contact.Size = new System.Drawing.Size(75, 52);
            this.btn_edition_list_contact.TabIndex = 0;
            this.btn_edition_list_contact.Text = "Editer une liste de contact";
            this.btn_edition_list_contact.UseVisualStyleBackColor = true;
            this.btn_edition_list_contact.Click += new System.EventHandler(this.btn_edition_list_contact_Click);
            // 
            // btn_edition_liste_participants
            // 
            this.btn_edition_liste_participants.Location = new System.Drawing.Point(171, 151);
            this.btn_edition_liste_participants.Name = "btn_edition_liste_participants";
            this.btn_edition_liste_participants.Size = new System.Drawing.Size(75, 56);
            this.btn_edition_liste_participants.TabIndex = 1;
            this.btn_edition_liste_participants.Text = "Editer la liste des participants";
            this.btn_edition_liste_participants.UseVisualStyleBackColor = true;
            this.btn_edition_liste_participants.Click += new System.EventHandler(this.btn_edition_liste_participants_Click);
            // 
            // btn_reteour
            // 
            this.btn_reteour.Location = new System.Drawing.Point(360, 309);
            this.btn_reteour.Name = "btn_reteour";
            this.btn_reteour.Size = new System.Drawing.Size(75, 23);
            this.btn_reteour.TabIndex = 2;
            this.btn_reteour.Text = "Retour";
            this.btn_reteour.UseVisualStyleBackColor = true;
            this.btn_reteour.Click += new System.EventHandler(this.btn_reteour_Click);
            // 
            // mode_edition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.btn_reteour);
            this.Controls.Add(this.btn_edition_liste_participants);
            this.Controls.Add(this.btn_edition_list_contact);
            this.Name = "mode_edition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mode édition";
            this.Load += new System.EventHandler(this.mode_edition_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_edition_list_contact;
        private System.Windows.Forms.Button btn_edition_liste_participants;
        private System.Windows.Forms.Button btn_reteour;
    }
}