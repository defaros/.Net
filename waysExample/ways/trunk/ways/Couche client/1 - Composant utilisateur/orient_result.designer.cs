namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class orient_result
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_envoyer_rapport_mail = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultats";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 59);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(296, 129);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_envoyer_rapport_mail
            // 
            this.btn_envoyer_rapport_mail.Location = new System.Drawing.Point(9, 193);
            this.btn_envoyer_rapport_mail.Margin = new System.Windows.Forms.Padding(2);
            this.btn_envoyer_rapport_mail.Name = "btn_envoyer_rapport_mail";
            this.btn_envoyer_rapport_mail.Size = new System.Drawing.Size(294, 24);
            this.btn_envoyer_rapport_mail.TabIndex = 2;
            this.btn_envoyer_rapport_mail.Text = "M\'envoyer le rapport par Email";
            this.btn_envoyer_rapport_mail.UseVisualStyleBackColor = true;
            this.btn_envoyer_rapport_mail.Click += new System.EventHandler(this.btn_envoyer_rapport_mail_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // orient_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_envoyer_rapport_mail);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "orient_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orient_result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orient_result_FormClosing);
            this.Load += new System.EventHandler(this.orient_result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_envoyer_rapport_mail;
        private System.Windows.Forms.Button button2;
    }
}