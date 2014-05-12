namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class liste_participants
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
            this.dgv_liste_participants = new System.Windows.Forms.DataGridView();
            this.btn_retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_participants)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_liste_participants
            // 
            this.dgv_liste_participants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_liste_participants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_liste_participants.Location = new System.Drawing.Point(12, 12);
            this.dgv_liste_participants.Name = "dgv_liste_participants";
            this.dgv_liste_participants.ReadOnly = true;
            this.dgv_liste_participants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_liste_participants.Size = new System.Drawing.Size(423, 289);
            this.dgv_liste_participants.TabIndex = 0;
            this.dgv_liste_participants.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_liste_participants_CellMouseDoubleClick);
            // 
            // btn_retour
            // 
            this.btn_retour.Location = new System.Drawing.Point(360, 309);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(75, 23);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour";
            this.btn_retour.UseVisualStyleBackColor = true;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // liste_participants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dgv_liste_participants);
            this.Name = "liste_participants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des participants";
            this.Load += new System.EventHandler(this.liste_participants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_liste_participants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_liste_participants;
        private System.Windows.Forms.Button btn_retour;
    }
}