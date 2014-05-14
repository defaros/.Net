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

namespace Ways.Client._1.Composant_utilisateurs
{
    public partial class EmailsForm : Form
    {
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
            }
            else
            {
                labelError.Visible = true;
            }
        }
    }
}
