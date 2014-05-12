using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._2___Composant_utilisateur_de_travail;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class jeu_result : Form
    {
        private MSG oMSG;
        private string mail;
        private CUT_ajouter_mail_contact cut;
        private CUT_envoyer_mail send;
        private string body;

        public jeu_result(MSG msg)
        {
            oMSG = new MSG();
            oMSG = msg;
            InitializeComponent();
            cut = new CUT_ajouter_mail_contact();
            send = new CUT_envoyer_mail();
            this.body = "";
        }

        private void jeu_result_Load(object sender, EventArgs e)
        {
            lbl_erreur.Visible = false;
            this.textBox2.Text = oMSG.GetData("score").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceuil acceuil = new acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void jeu_result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void jeu_result_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_ajouter_mail_Click(object sender, EventArgs e)
        {
            this.mail = tb_mail_contact.Text;

            oMSG.SetData("mail", this.mail);

            if (CUT_orient_presentation.IsEmail(oMSG))
            {
                lbl_erreur.Visible = false;

                cut.ajouter_mail_contact_cut(oMSG);
                this.body = "Promotion exia aix";
                oMSG.SetData("body", this.body);
                send.envoyer_mail(oMSG);

                tb_mail_contact.Clear();
            }
            else
            {
                lbl_erreur.Visible = true;
            }
        }
    }
}
