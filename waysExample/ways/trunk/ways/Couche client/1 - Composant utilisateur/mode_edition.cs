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
    public partial class mode_edition : Form
    {
        public mode_edition()
        {
            InitializeComponent();
        }

        private void btn_edition_list_contact_Click(object sender, EventArgs e)
        {
            liste_contacts form = new liste_contacts();
            form.Show();
            this.Hide(); 
        }

        private void btn_edition_liste_participants_Click(object sender, EventArgs e)
        {
            liste_participants form = new liste_participants();
            form.Show();
            this.Hide();
        }

        private void btn_reteour_Click(object sender, EventArgs e)
        {
            administration admin = new administration();
            admin.Show();
            this.Hide();
        }

        private void mode_edition_Load(object sender, EventArgs e)
        {

        }

    }
}
