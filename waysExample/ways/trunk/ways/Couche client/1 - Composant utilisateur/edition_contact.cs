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
using ways.Couche_client._2___Composant_utilisateur_de_travail;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class edition_contact : Form
    {
        private CUC cuc;
        private MSG msg;
        private string mail;

        public edition_contact()
        {
            InitializeComponent();
            cuc = new CUC();
        }

        public edition_contact(MSG msg)
        {
            InitializeComponent();
            this.msg = msg;
            cuc = new CUC();
        }

        private void edition_contact_Load(object sender, EventArgs e)
        {
            btn_enregistrer.Visible = false;
            lbl_erreur.Visible = false;

            DataSet ds = new DataSet();
            ds = (DataSet)this.msg.GetData("dataset");
            DataRow dr = ds.Tables[0].Rows[0];
            tb_mail.Text = dr[0].ToString();
            
            tb_mail.ReadOnly = true;
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.mail = this.tb_mail.Text;
            this.msg.SetData("valAMod", this.mail);
            tb_mail.ReadOnly = false;
            btn_enregistrer.Visible = true;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            
            this.mail = this.tb_mail.Text;

            this.msg.SetData("mail", this.mail);
            this.msg.Invoke= "Personnes_proc.modif_contact";
            if (CUT_orient_presentation.IsEmail(this.msg))
            {
                this.lbl_erreur.Visible = false;
                cuc.con_ToCS(this.msg);

                liste_contacts form = new liste_contacts();
                form.Show();
                this.Hide();
            }
            else
            {
                this.lbl_erreur.Visible = true;
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            liste_contacts form = new liste_contacts();
            form.Show();
            this.Hide();
        }
    }
}
