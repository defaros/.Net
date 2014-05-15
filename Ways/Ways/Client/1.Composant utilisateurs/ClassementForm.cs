using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateur_de_communication;
using System.Data.SqlClient;

namespace Ways.Client.Composant_utilisateurs
{
    public partial class ClassementForm : Form
    {
        Classement tempClass;
        public ClassementForm(Classement classement, User curentUser)
        {
            InitializeComponent();

            tempClass = classement;

            displayClassement(classement);

            displayUserScore(curentUser);

            UpdateDataGridViewParam();

        }

        public void displayClassement(Classement classement)
        {
            //Display un classement
            dataGridView1.DataSource = classement.users;
            dataGridView1.Update();
            

        }

        public void displayUserScore(User curentUser)
        {
            //Display le score d'un User
            labelNom.Text = curentUser.Nom;
            labelPosition.Text = curentUser.Place.ToString();
            textBoxScore.Text = curentUser.Score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            displayClassement(tempClass);
        }

        private void UpdateDataGridViewParam()
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();
        }

    }
}
