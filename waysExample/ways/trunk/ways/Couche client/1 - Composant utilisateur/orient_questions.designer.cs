using System.Collections.Generic;
using System.Windows.Forms;
using System;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using System.Data;
using ways.Couche_client._2___Composant_utilisateur_de_travail;
namespace ways.Couche_client._1___Composant_utilisateur
{
    partial class orient_questions
    {



        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        MSG oMSGQ = new MSG();
        MSG oMSGR = new MSG();
        CUC oCUC = new CUC();
        DataSet dataSet_questions = new DataSet();
        DataSet dataSet_reponses = new DataSet();
        private List<CheckBox> liste_check = new List<CheckBox>();
        private List<int> liste_idmetier = new List<int>();
        bool firstquestion = true;
        bool nextquestion;
        int compteur_question;
        int i;
        int t = 0;
        CUT_orientation_calcule orientation_calc = new CUT_orientation_calcule();
        DataRow rows_question;
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Suivant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);


            // 
            // orient_questions
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "orient_questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orient_questions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.orient_questions_FormClosing);
            this.Load += new System.EventHandler(this.orient_questions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Button button2;



    }

}