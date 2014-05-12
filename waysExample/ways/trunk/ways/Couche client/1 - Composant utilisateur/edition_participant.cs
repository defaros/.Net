using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class edition_participant : Form
    {
        private CUC cuc;
        private MSG msg;
        private string nom;
        private string score;
        private string id;

        public edition_participant()
        {
            InitializeComponent();
            cuc = new CUC();
        }

        public edition_participant(MSG msg)
        {
            InitializeComponent();
            this.msg = msg;
            cuc = new CUC();

        }

        private void edition_participant_Load(object sender, EventArgs e)
        {
            btn_enregistrer.Visible = false;
            tb_nom.ReadOnly = true;
            tb_score.ReadOnly = true;

            DataSet ds = new DataSet();
            ds = (DataSet)this.msg.GetData("dataset");
            DataRow dr = ds.Tables[0].Rows[0];
            this.id = dr[0].ToString();
            this.msg.SetData("id", this.id);
            this.msg.Invoke = "Personnes_proc.select_participant_by_id";

            this.msg = cuc.con_ToCS(this.msg);

            ds = (DataSet)this.msg.GetData("dataset");
            dr = ds.Tables[0].Rows[0];
            this.tb_nom.Text = dr[0].ToString();
            this.tb_score.Text = dr[1].ToString();

            
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            this.nom = this.tb_nom.Text;
            this.score = this.tb_score.Text;
            this.msg.SetData("valAMod1", this.nom);
            this.msg.SetData("valAMod2", this.score);

            tb_nom.ReadOnly = false;
            tb_score.ReadOnly = false;
            btn_enregistrer.Visible = true;
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            this.nom = this.tb_nom.Text;
            this.score = this.tb_score.Text;

            this.msg.SetData("nom", this.nom);
            this.msg.SetData("score", this.score);
            this.msg.SetData("id", this.id);
            this.msg.Invoke = "Personnes_proc.modif_participant";

            this.msg = cuc.con_ToCS(this.msg);

            liste_participants form = new liste_participants();
            form.Show();
            this.Hide();

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            liste_participants form = new liste_participants();
            form.Show();
            this.Hide();
        }
    }
}
