using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_client._2___Composant_utilisateur_de_travail;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class commercial_questions : Form
    {
        MSG oMSGQ = new MSG();
        MSG oMSGR = new MSG();
        MSG oMSG;
        CUC oCUC = new CUC();

        DataSet dataSet_questions = new DataSet();
        DataSet dataSet_reponses = new DataSet();
        List<CheckBox> liste_check = new List<CheckBox>();
        List<string> liste_idmetier = new List<string>();
        bool firstquestion = true;
        bool nextquestion;
        bool question_ouverte;
        int compteur_question;
        CUT_profilage cut_profil;
        int i;
        int t = 0;
        DataRow rows_question;

        public commercial_questions(MSG msg)
        {
            oMSG = new MSG();
            oMSG = msg;
            cut_profil = new CUT_profilage();
            InitializeComponent();
        }

        private void commercial_questions_Load(object sender, EventArgs e)
        {
            compteur_question = 0;
            charger_question(compteur_question);
            textBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if (question_ouverte)
            {
                oMSG.SetData("id_question", rows_question["id_question"]);
                oMSG.SetData("reponse", textBox1.Text);
                cut_profil.ajouter_reponse_com(oMSG);
                textBox1.Hide();
            }
            else
            {
                foreach (CheckBox check in liste_check)
                {
                    if (check.Checked)
                    {

                        oMSG.SetData("reponse", liste_idmetier[t]);
                        oMSG.SetData("id_question", rows_question["id_question"]);
                        cut_profil.ajouter_reponse_com(oMSG);
                        //score.ajout_score(msg);
                    }
                    t++;
                }
            }
            if (nextquestion == true)
            {
                compteur_question = compteur_question + 1;
                charger_question(compteur_question);
            }
            else
            {
                MessageBox.Show("Merci d'avoir répondu à ce questionnaire \n Vous allez maintenant commencer le Jeu");
                jeu_questions jeu = new jeu_questions();
                jeu.Show();
                this.Hide();
            }

        }

        private void commercial_questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void charger_question(int compteur_Q)
        {
            //Si c'est le chargement de la première question on recupère les questions
            if (firstquestion == true)
            {
                oMSGQ.Invoke = "Grp_Questions.selectionner_questions";
                oMSGQ.SetData("param1", "2");
                oMSGQ = oCUC.con_ToCS(oMSGQ);
                firstquestion = false;
            }
            dataSet_questions = (DataSet)oMSGQ.GetData("dataset");
            //on récupère la ligne correspondant à la ques
            rows_question = dataSet_questions.Tables[0].Rows[compteur_Q];

            this.label2.Location = new System.Drawing.Point(63, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = rows_question[3].ToString();


            ///////////////////////////////////////////GENERATION DE CHECKBOX POUR LES REPONSES///////////////
            oMSGR.SetData("id_question", rows_question["id_question"]);
            oMSGR.Invoke = "Grp_Reponse.selectionner_reponse_by_idq";
            oMSGR = oCUC.con_ToCS(oMSGR);
            dataSet_reponses = (DataSet)oMSGR.GetData("dataset");
            int x = 66;
            int y = 194;
            i = 0;
            if (firstquestion == false)
            {
                foreach (CheckBox check in liste_check)
                {
                    check.Hide();
                }
            }
            liste_check = new List<CheckBox>();

            if ((bool)rows_question["q_ouverte"])
            {
                foreach (DataRow rows_reponse in dataSet_reponses.Tables[0].Rows)
                {
                    liste_check.Add(new CheckBox());
                    liste_check[i].AutoSize = true;
                    liste_check[i].Location = new System.Drawing.Point(x, y);
                    liste_check[i].Name = "checkBox" + i;
                    liste_check[i].Size = new System.Drawing.Size(302, 21);
                    liste_check[i].TabIndex = 4 + i;
                    liste_check[i].Text = rows_reponse["nom_reponse"].ToString();
                    liste_check[i].UseVisualStyleBackColor = true;
                    y = y + 20;
                    try { liste_idmetier.Add((string)rows_reponse["nom_reponse"]); }
                    catch (Exception e) { MessageBox.Show("La récupération de la réponse a échouée."); }

                    i++;

                }
            }
            else
            {
                textBox1.Show();
                question_ouverte = true;

            }
            // 
            // orient_questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 424);
            foreach (CheckBox check in liste_check)
            {
                check.Visible = true;
                this.Controls.Add(check);
            }
            
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);


            if (dataSet_questions.Tables[0].Rows.Count > compteur_Q + 1)
            {
                nextquestion = true;
            }
            else
            {
                nextquestion = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
