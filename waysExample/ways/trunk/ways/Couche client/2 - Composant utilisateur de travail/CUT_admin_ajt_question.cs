using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
namespace ways.Couche_client._2___Composant_utilisateur_de_travail

{
    class CUT_admin_ajt_question
    {

        //Appel la fonction du CUC
        //Appel au CS
        private CUC cuc;

        public void m_ajouter_question_reponse(MSG oMSG){

            //vérifie une injection sql
            //verif = new CUT_verif_sql();
            //oMSG = verif.m_verif_injection_sql(oMSG);
            //appel au cs, et assignaton du nm de méthode pour

            string quetion = (string) oMSG.GetData("@question");
            bool ouv_fer = (bool) oMSG.GetData("@ouvertefermee");
            int nb_rep = 0;
            String rep1 = (string)oMSG.GetData("@rep1");
            String bar1 = (string)oMSG.GetData("@bar1");
            String rep2 = (string)oMSG.GetData("@rep2");
            String bar2 = (string)oMSG.GetData("@bar2");
            String rep3 = (string)oMSG.GetData("@rep3");
            String bar3 = (string)oMSG.GetData("@bar3");
            String rep4 = (string)oMSG.GetData("@rep4");
            String bar4 = (string)oMSG.GetData("@bar4");

            //MessageBox.Show(rep1 + "" + bar1 + "" + rep2 + "" + bar2 + "" + rep3 + "" + bar3 + "" + rep4 + "" + bar4);
            
            if (rep1 != null)nb_rep++;
            if (rep2 != null)nb_rep++;
            if (rep3 != null)nb_rep++;
            if (rep4 != null)nb_rep++;

            if (quetion != ""){
                if ((ouv_fer) && (nb_rep < 2)){
                    MessageBox.Show("Vous devez remplir au moins deux réponses pour valider");
                }
                else{
                    cuc = new CUC();
                    oMSG.Invoke = "ajout_question.m_ajouter_qr";
                    cuc.con_ToCS(oMSG);                    
                }
            }
            else{
                MessageBox.Show("Veuillez saisir une question");
            }
        }
    }
}
