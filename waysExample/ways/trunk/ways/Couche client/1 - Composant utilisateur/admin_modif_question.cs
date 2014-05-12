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
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class admin_modif_question : Form
    {
        private MSG oMSG;
        private CUT_admin_modif_question cuc;
        private CUC r_cuc;
        private DataSet ds;
        private DataRow dr;
        private CUT_admin_ajt_question cut;
        public admin_modif_question()
        {

            InitializeComponent();
        }

        public admin_modif_question(MSG msg)
        {
            InitializeComponent();
            textBox1.Text = msg.GetData("question").ToString();
            oMSG = msg;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Commerciale")
            {
                this.comboBox2.Enabled = true;
            }
            else if (comboBox1.SelectedItem.ToString() != "Commerciale")
            {
                this.comboBox2.Text = "Oui";
                this.comboBox2.Enabled = false;
            }
            if ((comboBox1.SelectedItem.ToString() == "Commerciale") && (comboBox2.SelectedItem.ToString() == "Oui"))
            {
                this.textBox5.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;

                this.comboBox3.Enabled = false;
                this.comboBox3.Text = "";
                this.comboBox4.Enabled = false;
                this.comboBox4.Text = "";
                this.comboBox5.Enabled = false;
                this.comboBox5.Text = "";
                this.comboBox6.Enabled = false;
                this.comboBox6.Text = "";
            }
            else if ((comboBox1.SelectedItem.ToString() != "Commerciale") && (comboBox2.SelectedItem.ToString() == "Oui"))
            {
                this.textBox5.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;

                if ((comboBox1.SelectedItem.ToString() == "Orientation"))
                {
                    //combobox = métiers
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                }
                else
                {
                    // combobox = scores
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                }

                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = true;
                this.comboBox6.Enabled = true;

            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedItem.ToString() == "Oui") && (comboBox1.SelectedItem.ToString() != "Commerciale"))
            {
                this.textBox5.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;

                if (comboBox1.SelectedItem.ToString() == "Orientation")
                {
                    //combobox = métiers
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                }
                else
                {
                    // combobox = scores
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                }

                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = true;
                this.comboBox6.Enabled = true;

            }
            else if (comboBox2.SelectedItem.ToString() == "Non")
            {
                this.textBox5.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.textBox4.Enabled = false;

                this.comboBox3.Enabled = false;
                this.comboBox3.Text = "";
                this.comboBox4.Enabled = false;
                this.comboBox4.Text = "";
                this.comboBox5.Enabled = false;
                this.comboBox5.Text = "";
                this.comboBox6.Enabled = false;
                this.comboBox6.Text = "";

            }
            else if ((comboBox2.SelectedItem.ToString() == "Oui") && (comboBox1.SelectedItem.ToString() == "Commerciale"))
            {
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;
                this.textBox5.Enabled = true;

                this.comboBox3.Enabled = false;
                this.comboBox3.Text = "";
                this.comboBox4.Enabled = false;
                this.comboBox4.Text = "";
                this.comboBox5.Enabled = false;
                this.comboBox5.Text = "";
                this.comboBox6.Enabled = false;
                this.comboBox6.Text = "";
            }
        }

        private void admin_modif_question_Load(object sender, EventArgs e)
        {

        }

        private void admin_modif_question_Load_1(object sender, EventArgs e)
        {
            String aaa = "";

            if(oMSG.GetData("param1").ToString() == "1")
                aaa = "Orientation";
            if (oMSG.GetData("param1").ToString() == "2")
                aaa = "Commerciale";
            if (oMSG.GetData("param1").ToString() == "3")
                aaa = "Jeu";

            comboBox1.Text = ""+aaa;

            oMSG.Invoke = "Grp_Questions.get_id_by_name";
            r_cuc = new CUC();
            oMSG = r_cuc.con_ToCS(oMSG);

            ds = (DataSet) oMSG.GetData("dataset");
            int i = (int)ds.Tables[0].Rows[0].ItemArray.GetValue(0);

            oMSG.SetData("id_question", i);
            oMSG.Invoke = "Grp_Reponse.selectionner_reponse_by_idq";
            oMSG = r_cuc.con_ToCS(oMSG);


            

            ds = (DataSet)oMSG.GetData("dataset");
            String rep1 = "";
            String rep2 = "";
            String rep3 = "";
            String rep4 = "";
            int z = 0;

            foreach (DataRow rows_reponse in ds.Tables[0].Rows)
            {
                z++;
            }
            if (z == 0) this.comboBox2.Text = "Non";
            if(z > 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                this.textBox2.Text = dr["nom_reponse"].ToString();
                if (dr["bareme"].ToString() != "") this.comboBox3.Text = dr["bareme"].ToString();

                if (dr["id_metier"].ToString() == "1") this.comboBox3.Text = "Web";
                if (dr["id_metier"].ToString() == "2") this.comboBox3.Text = "Jeux vidéo";
                if (dr["id_metier"].ToString() == "3") this.comboBox3.Text = "Téléphonie";
                if (dr["id_metier"].ToString() == "4") this.comboBox3.Text = "Chercheur";
                if (dr["id_metier"].ToString() == "5") this.comboBox3.Text = "Architecte SI";
                if (dr["id_metier"].ToString() == "6") this.comboBox3.Text = "Chef de projet";
                
                dr = ds.Tables[0].Rows[1];
                this.textBox3.Text = dr["nom_reponse"].ToString();
                if (dr["bareme"].ToString() != "") this.comboBox4.Text = dr["bareme"].ToString();

                if (dr["id_metier"].ToString() == "1") this.comboBox4.Text = "Web";
                if (dr["id_metier"].ToString() == "2") this.comboBox4.Text = "Jeux vidéo";
                if (dr["id_metier"].ToString() == "3") this.comboBox4.Text = "Téléphonie";
                if (dr["id_metier"].ToString() == "4") this.comboBox4.Text = "Chercheur";
                if (dr["id_metier"].ToString() == "5") this.comboBox4.Text = "Architecte SI";
                if (dr["id_metier"].ToString() == "6") this.comboBox4.Text = "Chef de projet";
            }
            if (z > 2)
            {
                DataRow dr = ds.Tables[0].Rows[2];
                this.textBox4.Text = dr["nom_reponse"].ToString();
                if (dr["bareme"].ToString() != "") this.comboBox5.Text = dr["bareme"].ToString();

                if (dr["id_metier"].ToString() == "1") this.comboBox5.Text = "Web";
                if (dr["id_metier"].ToString() == "2") this.comboBox5.Text = "Jeux vidéo";
                if (dr["id_metier"].ToString() == "3") this.comboBox5.Text = "Téléphonie";
                if (dr["id_metier"].ToString() == "4") this.comboBox5.Text = "Chercheur";
                if (dr["id_metier"].ToString() == "5") this.comboBox5.Text = "Architecte SI";
                if (dr["id_metier"].ToString() == "6") this.comboBox5.Text = "Chef de projet";

            }
            if (z > 3)
            {
                DataRow dr = ds.Tables[0].Rows[3];
                this.textBox5.Text = dr["nom_reponse"].ToString();
                if (dr["bareme"].ToString() != "") this.comboBox6.Text = dr["bareme"].ToString();

                if (dr["id_metier"].ToString() == "1") this.comboBox6.Text = "Web";
                if (dr["id_metier"].ToString() == "2") this.comboBox6.Text = "Jeux vidéo";
                if (dr["id_metier"].ToString() == "3") this.comboBox6.Text = "Téléphonie";
                if (dr["id_metier"].ToString() == "4") this.comboBox6.Text = "Chercheur";
                if (dr["id_metier"].ToString() == "5") this.comboBox6.Text = "Architecte SI";
                if (dr["id_metier"].ToString() == "6") this.comboBox6.Text = "Chef de projet";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_liste_questions li = new admin_liste_questions();
            li.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oMSG.Invoke = "Grp_Questions.delete_by_id";
            r_cuc = new CUC();
            oMSG = r_cuc.con_ToCS(oMSG);




            oMSG.SetData("@question", textBox1.Text.Trim());
            int nb_rep = 0;

            if (comboBox1.SelectedItem.ToString() == "Orientation") oMSG.SetData("@type", "1");
            else if (comboBox1.SelectedItem.ToString() == "Commerciale") oMSG.SetData("@type", "2");
            else if (comboBox1.SelectedItem.ToString() == "Jeu") oMSG.SetData("@type", "3");
            oMSG.SetData("@ouvertefermee", comboBox2.SelectedItem.ToString());
            //Si il y a des réponses prédéfinies
            if (comboBox2.SelectedItem.ToString() == "Oui")
            {

                //si la premiere réponce est définie
                if (textBox2.Text.Trim() != "")
                {
                    nb_rep += 1000;
                    oMSG.SetData("@rep1", textBox2.Text.Trim());
                    oMSG.SetData("@bar1", comboBox3.SelectedItem.ToString());
                }
                //Si la deuxieme réponse est définie
                if (textBox3.Text.Trim() != "")
                {
                    nb_rep += 200;
                    oMSG.SetData("@rep2", textBox3.Text.Trim());
                    oMSG.SetData("@bar2", comboBox4.SelectedItem.ToString());

                }
                //Si la troisieme réponse es définie
                if (textBox4.Text.Trim() != "")
                {
                    nb_rep += 30;
                    oMSG.SetData("@rep3", textBox4.Text.Trim());
                    oMSG.SetData("@bar3", comboBox5.SelectedItem.ToString());
                }
                //Si la quatrieme réponse est définie
                if (textBox5.Text.Trim() != "")
                {
                    nb_rep += 4;
                    oMSG.SetData("@rep4", textBox5.Text.Trim());
                    oMSG.SetData("@bar4", comboBox6.SelectedItem.ToString());
                }
                oMSG.SetData("nb_rep", nb_rep);
            }
            cut = new CUT_admin_ajt_question();
            cut.m_ajouter_question_reponse(oMSG);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
                if (comboBox1.SelectedItem.ToString() == "Commerciale")
                {
                    this.comboBox2.Enabled = true;
                }
                else if (comboBox1.SelectedItem.ToString() != "Commerciale")
                {
                    this.comboBox2.Text = "Oui";
                    this.comboBox2.Enabled = false;
                }
                if ((comboBox1.SelectedItem.ToString() == "Commerciale") && (comboBox2.SelectedItem.ToString() == "Oui"))
                {
                    this.textBox5.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    this.textBox4.Enabled = true;

                    this.comboBox3.Enabled = false;
                    this.comboBox3.Text = "";
                    this.comboBox4.Enabled = false;
                    this.comboBox4.Text = "";
                    this.comboBox5.Enabled = false;
                    this.comboBox5.Text = "";
                    this.comboBox6.Enabled = false;
                    this.comboBox6.Text = "";
                }
                else if ((comboBox1.SelectedItem.ToString() != "Commerciale") && (comboBox2.SelectedItem.ToString() == "Oui"))
                {
                    this.textBox5.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    this.textBox4.Enabled = true;

                    if ((comboBox1.SelectedItem.ToString() == "Orientation"))
                    {
                        //combobox = métiers
                        this.comboBox3.Items.Clear();
                        this.comboBox3.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox4.Items.Clear();
                        this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox5.Items.Clear();
                        this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox6.Items.Clear();
                        this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    }
                    else
                    {
                        // combobox = scores
                        this.comboBox3.Items.Clear();
                        this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox4.Items.Clear();
                        this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox5.Items.Clear();
                        this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox6.Items.Clear();
                        this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    }

                    this.comboBox3.Enabled = true;
                    this.comboBox4.Enabled = true;
                    this.comboBox5.Enabled = true;
                    this.comboBox6.Enabled = true;

                }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if ((comboBox2.SelectedItem.ToString() == "Oui") && (comboBox1.SelectedItem.ToString() != "Commerciale"))
                {
                    this.textBox5.Enabled = true;
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    this.textBox4.Enabled = true;

                    if (comboBox1.SelectedItem.ToString() == "Orientation")
                    {
                        //combobox = métiers
                        this.comboBox3.Items.Clear();
                        this.comboBox3.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox4.Items.Clear();
                        this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox5.Items.Clear();
                        this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                        this.comboBox6.Items.Clear();
                        this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    }
                    else
                    {
                        // combobox = scores
                        this.comboBox3.Items.Clear();
                        this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox4.Items.Clear();
                        this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox5.Items.Clear();
                        this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                        this.comboBox6.Items.Clear();
                        this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    }

                    this.comboBox3.Enabled = true;
                    this.comboBox4.Enabled = true;
                    this.comboBox5.Enabled = true;
                    this.comboBox6.Enabled = true;

                }
                else if (comboBox2.SelectedItem.ToString() == "Non")
                {
                    this.textBox5.Enabled = false;
                    this.textBox2.Enabled = false;
                    this.textBox3.Enabled = false;
                    this.textBox4.Enabled = false;
                    this.comboBox3.Enabled = false;
                    this.comboBox3.Text = "";
                    this.comboBox4.Enabled = false;
                    this.comboBox4.Text = "";
                    this.comboBox5.Enabled = false;
                    this.comboBox5.Text = "";
                    this.comboBox6.Enabled = false;
                    this.comboBox6.Text = "";

                }
                else if ((comboBox2.SelectedItem.ToString() == "Oui") && (comboBox1.SelectedItem.ToString() == "Commerciale"))
                {
                    this.textBox2.Enabled = true;
                    this.textBox3.Enabled = true;
                    this.textBox4.Enabled = true;
                    this.textBox5.Enabled = true;

                    this.comboBox3.Enabled = false;
                    this.comboBox3.Text = "";
                    this.comboBox4.Enabled = false;
                    this.comboBox4.Text = "";
                    this.comboBox5.Enabled = false;
                    this.comboBox5.Text = "";
                    this.comboBox6.Enabled = false;
                    this.comboBox6.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oMSG.Invoke = "Grp_Questions.delete_by_id";
            r_cuc = new CUC();
            oMSG = r_cuc.con_ToCS(oMSG);
            admin_liste_questions li = new admin_liste_questions();
            li.Show();
            this.Hide();
        }
    }
}
