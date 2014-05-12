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
    public partial class orient_result : Form
    {
        private MSG oMSG;
        private string body;
        private CUT_envoyer_mail envoyer_mail;

        public orient_result(MSG msg)
        {
            oMSG = new MSG();
            oMSG = msg;
            InitializeComponent();
            envoyer_mail = new CUT_envoyer_mail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            commercial_questions com = new commercial_questions(oMSG);
            com.Show();
            this.Hide();
        }

        private void orient_result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void orient_result_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = (string)oMSG.GetData("result_orientation");
        }

        private void btn_envoyer_rapport_mail_Click(object sender, EventArgs e)
        {
            this.body = oMSG.GetData("result_orientation").ToString();

            oMSG.SetData("body" ,this.body);

            envoyer_mail.envoyer_mail(oMSG);

        }
    }
}
