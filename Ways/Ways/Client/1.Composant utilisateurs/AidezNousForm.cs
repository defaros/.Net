using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_de_travail;
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Client._1.Composant_utilisateurs
{
    public partial class AidezNousForm : Form
    {
        public Reponse reponse;
        int pointsEarned = 0;
        bool goodToGo;
        bool goodToSend;

        public AidezNousForm()
        {
            InitializeComponent();

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;


            goodToGo = true;
            goodToSend = true;
            labelError.Visible = false;
            labelError2.Visible = false;

            labelErrorNom.Visible = false;
            labelErrorPrenom.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goodToGo = true;
            goodToSend = true;
            labelError.Visible = false;
            labelError2.Visible = false;

            labelErrorNom.Visible = false;
            labelErrorPrenom.Visible = false;


            Regex regNom = new Regex(@"^[a-zA-Z]+$");

            if (regNom.IsMatch(textBoxNom.Text))
            {
                labelErrorNom.Visible = false;
            }
            else
            {
                labelErrorNom.Visible = true;
                goodToSend = false;
                goodToGo = false;
            }

            if (regNom.IsMatch(textBoxPrenom.Text))
            {
                labelErrorPrenom.Visible = false;
            }
            else
            {
                labelErrorPrenom.Visible = true;
                goodToSend = false;
                goodToGo = false;
            }

            if (textBoxEmail.Text != "")
            {
                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (reg.IsMatch(textBoxEmail.Text) && textBoxEmail.Enabled)
                {
                    textBoxEmail.Enabled = false;
                    if (goodToSend)
                    {
                        textBoxEmail2.Enabled = false;
                        TravailClient.sendEmail(textBoxEmail.Text, textBoxNom.Text, textBoxPrenom.Text);
                        pointsEarned += 2;
                    }
                }
                else
                {
                    labelError2.Visible = false;
                    labelError.Visible = true;
                    goodToGo = false;
                }
            }


            if (textBoxEmail2.Text != "")
            {
                Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (reg.IsMatch(textBoxEmail2.Text) && textBoxEmail2.Enabled)
                {
                    if (goodToSend)
                    {
                        textBoxEmail2.Enabled = false;
                        TravailClient.sendEmail(textBoxEmail2.Text, textBoxNom.Text, textBoxPrenom.Text);
                        pointsEarned += 2;
                    }
                }
                else
                {
                    labelError2.Visible = true;
                    goodToGo = false;
                }
            }
            
            if(goodToGo)
            {
                this.reponse = new Reponse("Aidez Nous", pointsEarned,-1);
                this.Close();
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            //retour Menu principal
            this.reponse = new Reponse("Pas de réponse", -1,-1);
            this.Close();
        }
    }
}
