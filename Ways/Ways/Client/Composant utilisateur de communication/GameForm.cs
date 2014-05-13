using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_utilisateurs;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public partial class GameForm : Form
    {
        public GameForm(Question[] questions)
        {
            InitializeComponent();

            int i = questions.Length;

            for (i=0; i<questions.Length; i++)
            {
                displayNewQuestion(questions[i], i);
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void displayNewQuestion(Question question, int numQuestion)
        {
            labelQuestion.Text = "Question n°" + numQuestion;

            labelEnonce.Text = question.enonce;


            radioButton1.Text = question.reponses[0].reponse;
            radioButton2.Text = question.reponses[1].reponse;
            radioButton3.Text = question.reponses[2].reponse;
            radioButton4.Text = question.reponses[3].reponse;

            foreach ( RadioButton radBut in this)
            {
                if (radBut.Text == null)
                {
                    radBut.Hide();
                }
            }
        }
    }
}
