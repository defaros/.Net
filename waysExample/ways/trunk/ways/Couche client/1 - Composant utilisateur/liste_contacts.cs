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
    public partial class liste_contacts : Form
    {
        public liste_contacts()
        {
            InitializeComponent();
        }

        private void liste_contacts_Load(object sender, EventArgs e)
        {
            MSG monMsg = new MSG();
            monMsg.Invoke = "Personnes_proc.list_contact";

            CUC cuc = new CUC();
            monMsg = cuc.con_ToCS(monMsg);

            DataSet ds = new DataSet();
            ds = (DataSet)monMsg.GetData("dataset");
            dgv_liste_contact.DataSource = ds;
            dgv_liste_contact.DataMember = ds.Tables[0].TableName;

            //dgv_liste_contact.DataMember = ds.Tables[0].Columns[0].ColumnName = "Nom";
            //dgv_liste_contact.DataMember = ds.Tables[0].Columns[1].ColumnName = "Adresse mail";
            //dgv_liste_contact.DataMember = ds.Tables[0].Columns[2].ColumnName = "Email";
        }

        private void dgv_liste_contact_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(dgv_liste_contact.SelectedCells[0].Value.ToString());
            string valeurCell = dgv_liste_contact.SelectedCells[0].Value.ToString();

            MSG monMsg = new MSG();
            monMsg.SetData("valCell", valeurCell);
            monMsg.Invoke = "Personnes_proc.select_contact";

            CUC cuc = new CUC();
            monMsg = cuc.con_ToCS(monMsg);

            edition_contact form = new edition_contact(monMsg);
            form.Show();
            this.Hide();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            mode_edition form = new mode_edition();
            form.Show();
            this.Hide();
        }
    }
}
