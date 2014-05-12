using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware._5___Groupe_de_processus;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_client._2___Composant_utilisateur_de_travail;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class orient_presentation : Form
    {
        private string nom;
        private string prenom;
        private string adresse;
        private string mail;
        private string telephone;
        private string date_de_naissance;
        private CUC cuc;
        private MSG monMsg;
        private MSG msgMail;
        private MSG msgId;


        public orient_presentation()
        {
            InitializeComponent();
            cuc = new CUC();
            monMsg = new MSG();
            msgMail = new MSG();
            msgId = new MSG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nom = this.tb_nom.Text;
            this.prenom = this.tb_prenom.Text;
            this.adresse = this.tb_adresse.Text;
            this.mail = this.tb_mail.Text;
            this.telephone = this.tb_tel.Text;
            this.date_de_naissance = this.tb_date_de_naissance.Text;

            
            monMsg.SetData("nom", this.nom);
            monMsg.SetData("prenom", this.prenom);
            monMsg.SetData("adresse", this.adresse);
            monMsg.SetData("mail", this.mail);
            monMsg.SetData("telephone", this.telephone);
            monMsg.SetData("date_de_naissance", this.date_de_naissance);
            monMsg.Invoke = "Personnes_proc.ajout_info_perso";

            msgId.SetData("nom", this.nom);
            msgId.SetData("prenom", this.prenom);
            msgId.Invoke = "Personnes_proc.select_id_personne";

            msgMail.SetData("mail", this.mail);


            if (CUT_orient_presentation.IsFully(monMsg))
            {
                this.lbl_erreur_champs.Visible = false;

                if (CUT_orient_presentation.IsEmail(monMsg))
                {
                    this.lbl_erreur.Visible = false;
                    cuc.con_ToCS(monMsg);
                    msgId = cuc.con_ToCS(msgId);
                    DataSet ds = (DataSet)msgId.GetData("dataset");
                    DataRow dr = ds.Tables[0].Rows[0];
                    msgMail.SetData("id_personne", dr[0]);
                    if (monMsg.Statut == true)
                    {
                        MessageBox.Show("Vos informations ont bien été enregistrées");
                    }

                    orient_questions orient_questions = new orient_questions(msgMail);
                    orient_questions.Show();
                    this.Hide();
                }
                else
                {
                    this.lbl_erreur.Visible = true;
                }
            }
            else
            {
                this.lbl_erreur_champs.Visible = true;
            }
        }

        private void orient_presentation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orient_presentation_Load(object sender, EventArgs e)
        {
            this.lbl_erreur.Visible = false;
            this.lbl_erreur_champs.Visible = false;
        }

        private void bnt_retour_Click(object sender, EventArgs e)
        {
            acceuil form = new acceuil();
            form.Show();
            this.Hide();
        }
    }
}
