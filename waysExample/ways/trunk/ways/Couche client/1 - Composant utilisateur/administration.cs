using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class administration : Form
    {
        public administration()
        {
            InitializeComponent();
        }

        private void admin_questions_Load(object sender, EventArgs e)
        {

        }

        private void bnt_retour_Click(object sender, EventArgs e)
        {
            acceuil acceuil = new acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void administration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bnt_scores_Click(object sender, EventArgs e)
        {
            liste_participants form = new liste_participants();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_ajt_question ajt = new admin_ajt_question();
            ajt.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_liste_questions li_q = new admin_liste_questions();
            li_q.Show();
        }

        private void btn_list_contacts2_Click(object sender, EventArgs e)
        {
            mode_edition form = new mode_edition();
            form.Show();
            this.Hide();
        }
    }
}
