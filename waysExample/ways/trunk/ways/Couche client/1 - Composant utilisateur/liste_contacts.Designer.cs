namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class liste_contacts
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
            this.dgv_liste_contact = new System.Windows.Forms.DataGridView();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_contact)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste_contact
            // 
            this.dgv_liste_contact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_contact.Location = new System.Drawing.Point(12, 12);
            this.dgv_liste_contact.Name = "dgv_liste_contact";
            this.dgv_liste_contact.ReadOnly = true;
            this.dgv_liste_contact.Size = new System.Drawing.Size(423, 320);
            this.dgv_liste_contact.TabIndex = 0;
            this.dgv_liste_contact.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_liste_contact_CellMouseDoubleClick);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(360, 338);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // liste_contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 370);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_liste_contact);
            this.Name = "liste_contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liste_contacts";
            this.Load += new System.EventHandler(this.liste_contacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_contact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_contact;
        private System.Windows.Forms.Button btn_retour;
    }
}