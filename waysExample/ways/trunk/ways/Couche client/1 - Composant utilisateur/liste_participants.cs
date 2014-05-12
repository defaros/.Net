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

namespace ways.Couche_client._1___Composant_utilisateur
{
    public partial class liste_participants : Form
    {
        public liste_participants()
        {
            InitializeComponent();
        }

        private void liste_participants_Load(object sender, EventArgs e)
        {
            MSG monMsg = new MSG();
            monMsg.Invoke = "Personnes_proc.list_participant";

            CUC cuc = new CUC();
            monMsg = cuc.con_ToCS(monMsg);

            DataSet ds = new DataSet();
            ds = (DataSet)monMsg.GetData("dataset");
            dgv_liste_participants.DataSource = ds;
            dgv_liste_participants.DataMember = ds.Tables[0].TableName;
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            mode_edition form = new mode_edition();
            form.Show();
            this.Hide();
        }

        private void dgv_liste_participants_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nom = dgv_liste_participants.Rows[e.RowIndex].Cells[0].Value.ToString();

            MSG monMsg = new MSG();
            monMsg.SetData("nom", nom);
            monMsg.Invoke = "Personnes_proc.select_id_participant";

            CUC cuc = new CUC();
            monMsg = cuc.con_ToCS(monMsg);

            edition_participant form = new edition_participant(monMsg);
            form.Show();
            this.Hide();
        }
    }
}
