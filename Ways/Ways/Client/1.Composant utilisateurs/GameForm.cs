using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Client.Composant_de_travail;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Client.Composant_utilisateurs;

namespace Ways.Client.Composant_utilisateurs
{
    public partial class GameForm : Form
    {
        //Liste des questions à afficher
        public Question[] questionsToDisplay = null;
        //Numéro de la question en cours
        public int numCurrentQuestion = 0;
        //Liste des réponses choisies par l'utilisateur
        List<Reponse> reponsesDonnees = new List<Reponse>();

        public GameForm(Question[] questions, int typeJeu)
        {
            InitializeComponent();

            //Mise en forme de la fenêtre
            if (typeJeu == 0)
            {
                this.Text = "Section Orientation";
            }
            else
            {
                this.Text = "Section Jeu";
            }

            //Mise à zéro des radioButtons
            radioButton1.Text = null;
            radioButton2.Text = null;
            radioButton3.Text = null;
            radioButton4.Text = null;


            //Affichage de la première question
            questionsToDisplay = questions;

            if (questionsToDisplay != null)
            {
                displayNewQuestion(questionsToDisplay[numCurrentQuestion], numCurrentQuestion + 1);
            }
            else
            {
                //displayError
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //Ne sert à rien, je n'arive pas à l'enlever
        }



        private void displayNewQuestion(Question question, int numQuestion)
        {
            //On rempli l'énoncé
            labelQuestion.Text = "Question n°" + numQuestion;

            labelEnonce.Text = question.enonce;

            //On remplis les radioButtons
            try
            {
                radioButton1.Text = question.reponses[0].reponse;
                radioButton2.Text = question.reponses[1].reponse;
                radioButton3.Text = question.reponses[2].reponse;
                radioButton4.Text = question.reponses[3].reponse;
            }
            catch(Exception) { }

            //Si un radioButton est vide on le cache
            foreach ( RadioButton radBut in this.Controls.OfType<RadioButton>())
            {
                if (radBut.Text == "")
                {
                    radBut.Hide();
                }
            }
        }



        private void buttonValider_Click(object sender, EventArgs e)
        {

            //On recupère la réponse choisie
            foreach (RadioButton radBut in this.Controls.OfType<RadioButton>())
            {
                if (radBut.Checked == true)
                {
                    foreach (Reponse rep in questionsToDisplay[numCurrentQuestion].reponses)
                    {
                        if (radBut.Text == rep.reponse)
                        {
                            reponsesDonnees.Add(rep);
                            break;
                        }
                    }
                }
            }

            //On affiche la nouvelle question
            numCurrentQuestion++;

            if (numCurrentQuestion < questionsToDisplay.Length)
            {
                displayNewQuestion(questionsToDisplay[numCurrentQuestion], numCurrentQuestion + 1);
            }
            else
            {
                Reponse repAidez = TravailClient.showAidezNousForm();
                Reponse repEmail = null;

                if (repAidez.reponse != null)
                {
                    repEmail = TravailClient.showEmailForm();
                }




                ClassementForm CF = new ClassementForm(null,null);
                CF.Show();
                this.Hide();
            }

        }
    }
}
