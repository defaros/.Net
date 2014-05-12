using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_client._2___Composant_utilisateur_de_travail;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware._5___Groupe_de_processus;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class admin_liste_questions : Form
    {
        private MSG oMSG;
        private CUT_admin_modif_question cut;
        private admin_modif_question modif;
        private DataSet ds;
        private CUC cuc;
        public admin_liste_questions()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Créer une nouvelle instance de la fenetre de modification avec 
            //la question cliqué en argument
            //(faire la fenetre de modification et le constructeur surchargée prennant 
            //le String "type" en argument) Ou charger la question "On load"
            //admin_modif_question modiff = new admin_modif_question();
            //modiff.Show();
            //this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            oMSG = new MSG();
            if (comboBox1.SelectedItem.ToString() == "Orientation")
                oMSG.SetData("@type", 1);
            else if (comboBox1.SelectedItem.ToString() == "Commerciale")
                oMSG.SetData("@type", 2);
            else if (comboBox1.SelectedItem.ToString() == "Jeu")
                oMSG.SetData("@type", 3);

            /////////////////////////////////////////////////////////
            oMSG.SetData("param1", oMSG.GetData("@type"));
            oMSG.Invoke = "Grp_Questions.selectionner_questions";
            cuc = new CUC();
            oMSG = cuc.con_ToCS(oMSG);

            listBox1.Items.Clear();

            ds = (DataSet)oMSG.GetData("dataset");
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    this.listBox1.Items.Add(row["question"].ToString());
                }
            }

        }

        private void admin_liste_questions_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Voir_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                oMSG.SetData("question", listBox1.SelectedItem.ToString());
                modif = new admin_modif_question(oMSG);
                modif.Show();                
                this.Hide();
            }
        }
    }
}
