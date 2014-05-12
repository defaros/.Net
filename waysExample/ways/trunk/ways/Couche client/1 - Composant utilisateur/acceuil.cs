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
    public partial class acceuil : Form
    {
        public acceuil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_connect admin_connect = new admin_connect();
            admin_connect.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orient_presentation orient_presentation = new orient_presentation();
            orient_presentation.Show();
            this.Hide();
        }

        private void acceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void acceuil_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
