using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_client._2___Composant_utilisateur_de_travail;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class admin_ajt_question : Form
    {
        private MSG oMSG = new MSG();
        private CUT_admin_ajt_question cut;
        public admin_ajt_question()
        {
            InitializeComponent();
        }

        private void admin_ajt_question_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Commerciale")
            {
                this.comboBox2.Enabled = true;
                this.comboBox2.Text = "Oui";
            }
            else if(comboBox1.SelectedItem.ToString() != "Commerciale")
            {
                this.comboBox2.Text = "Oui";
                this.comboBox2.Enabled = false;
            }
            if ((comboBox1.SelectedItem.ToString() == "Commerciale")&&(comboBox2.SelectedItem.ToString() == "Oui"))
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
            else if ((comboBox1.SelectedItem.ToString() != "Commerciale")&&(comboBox2.SelectedItem.ToString() == "Oui"))
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
                    this.comboBox3.Text = "Web";

                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox4.Text = "Web";

                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox5.Text = "Web";

                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox6.Text = "Web";
                }
                else{
                    // combobox = scores
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox3.Text = "0";

                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"});
                    this.comboBox4.Text = "0";

                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox5.Text = "0";
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox6.Text = "0";
                }

                this.comboBox3.Enabled = true;
                this.comboBox4.Enabled = true;
                this.comboBox5.Enabled = true;
                this.comboBox6.Enabled = true;

            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((comboBox2.SelectedItem.ToString() == "Oui")&&(comboBox1.SelectedItem.ToString() != "Commerciale"))
            {
                this.textBox5.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = true;
                this.textBox4.Enabled = true;

                if(comboBox1.SelectedItem.ToString() == "Orientation"){
                    //combobox = métiers
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"});
                    this.comboBox3.Text = "Web";
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"}); this.comboBox4.Text = "Web";
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"}); this.comboBox5.Text = "Web";
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "Web",
                    "Jeux vidéo",
                    "Téléphonie",
                    "Chercheur",
                    "Architecte SI",
                    "Chef de projet"}); this.comboBox6.Text = "Web";
                }
                else{
                    // combobox = scores
                    this.comboBox3.Items.Clear();
                    this.comboBox3.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox3.Text = "0";
                    this.comboBox4.Items.Clear();
                    this.comboBox4.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox4.Text = "0";
                    this.comboBox5.Items.Clear();
                    this.comboBox5.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox5.Text = "0";
                    this.comboBox6.Items.Clear();
                    this.comboBox6.Items.AddRange(new object[] {
                    "0",
                    "1",
                    "2"}); this.comboBox6.Text = "0";
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

        //Click sur le bouton ajouter
        private void button1_Click_1(object sender, EventArgs e){
            oMSG.SetData("@question", textBox1.Text.Trim());
            int nb_rep = 0;

            if (comboBox1.SelectedItem.ToString() == "Orientation") oMSG.SetData("@type", "1");
            else if (comboBox1.SelectedItem.ToString() == "Commerciale")
            {
                oMSG.SetData("@type", "2");
                oMSG.SetData("@ouvertefermee", comboBox2.SelectedItem.ToString());
                if ((string)oMSG.GetData("@ouvertefermee") == "non")
                {
                    oMSG.SetData("@ouvertefermee", true);
                }
                else
                {
                    oMSG.SetData("@ouvertefermee", false);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Jeu") oMSG.SetData("@type", "3");

            

            //Si il y a des réponses prédéfinies
            if(comboBox2.SelectedItem.ToString() == "Oui"){

                //si la premiere réponce est définie
                if (textBox2.Text.Trim() != "")
                {
                    nb_rep += 1000;
                    oMSG.SetData("@rep1", textBox2.Text.Trim());
                    oMSG.SetData("@bar1", comboBox3.SelectedItem.ToString());
                }
                //Si la deuxieme réponse est définie
                if(textBox3.Text.Trim() != ""){
                    nb_rep += 200;
                    oMSG.SetData("@rep2", textBox3.Text.Trim());
                    oMSG.SetData("@bar2", comboBox4.SelectedItem.ToString());
                    
                }
                //Si la troisieme réponse es définie
                if(textBox4.Text.Trim() != ""){
                    nb_rep += 30;
                    oMSG.SetData("@rep3", textBox4.Text.Trim());
                    oMSG.SetData("@bar3", comboBox5.SelectedItem.ToString());
                }
                //Si la quatrieme réponse est définie
                if (textBox5.Text.Trim() != ""){
                    nb_rep += 4;
                    oMSG.SetData("@rep4", textBox5.Text.Trim());
                    oMSG.SetData("@bar4", comboBox6.SelectedItem.ToString());
                }
                oMSG.SetData("nb_rep", nb_rep);
            }
            cut = new CUT_admin_ajt_question();
            cut.m_ajouter_question_reponse(oMSG);

            this.Hide();
            admin_ajt_question ajt = new admin_ajt_question();
            ajt.Show();
        }
        
        //Bouton retour
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void admin_ajt_question_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        

    }
}
