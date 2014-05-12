using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class orient_questions : Form
    {
        private MSG msg;
        public orient_questions(MSG msg)
        {
            InitializeComponent();
            this.msg = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void orient_questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void orient_questions_Load(object sender, EventArgs e)
        {
            compteur_question = 0;
            charger_question(compteur_question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (CheckBox check in liste_check)
            {
                if (check.Checked)
                {
                    this.msg.SetData("id_metier", liste_idmetier[t]);
                    orientation_calc.ajout_reponse(this.msg);
                }
                t++;
            }
            if (nextquestion == true)
            {
                compteur_question = compteur_question + 1;
                charger_question(compteur_question);
            }
            else
            {
                
                orient_result orient_result = new orient_result(orientation_calc.choix_orientation(msg));
                orient_result.Show();
                this.Hide();
            }
        }
        public void charger_question(int compteur_Q)
        {
            if (firstquestion == true)
            {
                oMSGQ.Invoke = "Grp_Questions.selectionner_questions";
                oMSGQ.SetData("param1", "1");
                oMSGQ = oCUC.con_ToCS(oMSGQ);
                firstquestion = false;
            }
            dataSet_questions = (DataSet)oMSGQ.GetData("dataset");

            rows_question = dataSet_questions.Tables[0].Rows[compteur_Q];
            // 
            // label2
            // 

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = rows_question[3].ToString(); 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Réponses";
            // 
            // checkBox1
            // 

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
                try { liste_idmetier.Add((int)rows_reponse["id_metier"]); }
                catch (Exception e) { MessageBox.Show("récupération de l'id_metier a échoué"); }

                i++;

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
    }
}
