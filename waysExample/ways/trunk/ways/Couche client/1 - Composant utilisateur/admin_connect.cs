using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;





namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class admin_connect : Form
    {
        private CUC oCUC;
        private CAD oCAD;
        private MSG oMSG;

        public admin_connect()
        {
            oMSG = new MSG();
            oCUC = new CUC();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            oMSG.SetData("log",textBox1.Text);
            oMSG.SetData("mdp", textBox2.Text);

            oMSG.Invoke = "Personnes_proc.selectionner_Admin";
            oMSG = oCUC.con_ToCS(oMSG);
            if (oMSG.Statut == true)
            {
                administration admin = new administration();
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Le mot de passe ou le login n'est pas incorrect veuillez réessayer");
            }
       
        }

        private void admin_connect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void admin_connect_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
