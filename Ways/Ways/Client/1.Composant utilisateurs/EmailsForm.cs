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
using Ways.Client.Composant_utilisateur_de_communication;

namespace Ways.Client._1.Composant_utilisateurs
{
    public partial class EmailsForm : Form
    {
        public Reponse rep = null;

        public EmailsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if(reg.IsMatch(textBox1.Text))
            {
                labelError.Visible = false;
                //send Email
                this.rep = new Reponse("Email", 2);
                this.Close();
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.rep = new Reponse("Pas de reponse", 0);

            this.Close();
        }
    }
}
