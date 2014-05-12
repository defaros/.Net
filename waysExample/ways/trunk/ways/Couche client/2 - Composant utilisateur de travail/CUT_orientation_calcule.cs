using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Windows.Forms;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using System.Data;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_orientation_calcule
    {
        private List<int> liste_checked;
        private CUC oCUC;
        private DataSet ds;
        private DataRow dr;


        public CUT_orientation_calcule()
        {
           liste_checked = new List<int>();
           oCUC = new CUC();
        }
        public void ajout_reponse(MSG msg)
        {
            liste_checked.Add((int)msg.GetData("id_metier"));
            Console.WriteLine(msg.GetData("id_metier"));
        }
        public MSG choix_orientation(MSG msg)
        {
                int m1 = 0;
                int m2 = 0;
                int m3 = 0;
                int m4 = 0;
                int m5 = 0;
                int m6 = 0;
                int id_a_selectionner;
            foreach (int id_metier in liste_checked)
            {

                if (id_metier == 1)
                {
                    m1++;
                }
                else if(id_metier == 2)
                {
                    m2++;
                }
                else if (id_metier == 3)
                {
                    m3++;
                }
                else if (id_metier == 4)
                {
                    m4++;
                }
                else if (id_metier == 5)
                {
                    m5++;
                }
                else if (id_metier == 6)
                {
                    m6++;
                }
            }
            int[] metier = new int[6]{m1,m2,m3,m4,m5,m6};
            id_a_selectionner = metier.Max() / metier.Max();
            msg.SetData("id_metier",id_a_selectionner);
            msg.Invoke = "Grp_Metier.selectionner_metier_by_id";
            msg = oCUC.con_ToCS(msg);

            ds = (DataSet)msg.GetData("dataset");
            dr = ds.Tables[0].Rows[0];
            msg.SetData("result_orientation","Le métier vous correspondant le mieu est : \n"+dr["nom_metier"] + " : "+ dr["description_metier"]);
            return msg;
        }
    }
}
