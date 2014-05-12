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
    public partial class scores : Form
    {
        public scores()
        {
            InitializeComponent();
        }

        private void scores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            administration admin = new administration();
            admin.Show();
            this.Hide();
        }
    }
}
