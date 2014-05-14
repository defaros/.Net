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
    public partial class AdminForm : Form
    {
        Question newQuest = new Question(-1, "Nouvelle question", null, null);

        public AdminForm(List<Question> questionsJeu, List<Question> questionsOrientation, List<string> paramEmail)
        {
            InitializeComponent();


            //Initialisation des combobox pour avoir la possibilité de créer une nouvelle question
            comboBoxJeu.Items.Add(newQuest);
            comboBoxOrientation.Items.Add(newQuest);

            comboBoxJeu.SelectedItem = newQuest;
            comboBoxOrientation.SelectedItem = newQuest;


            //Affichage des questions existantes
            if (questionsJeu != null)
            {
                foreach (Question quest in questionsJeu)
                {
                    comboBoxJeu.Items.Add(quest);
                }
            }

            if (questionsOrientation != null)
            {
                foreach (Question quest in questionsOrientation)
                {
                    comboBoxOrientation.Items.Add(quest);
                }
            }
        }



        private void comboBoxJeu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage des informations d'une question lorsqu'elle est sélectionnée dans la liste
            Question currentQuest = (Question)comboBoxJeu.SelectedItem;

            richTextBoxJeu.Text = currentQuest.enonce;

            

            try
            {
                textBoxJeuRep1.Text = currentQuest.reponses[0].reponse;
                textBoxJeuPoints1.Text = currentQuest.reponses[0].points.ToString();
                textBoxJeuRep2.Text = currentQuest.reponses[1].reponse;
                textBoxJeuPoints2.Text = currentQuest.reponses[1].points.ToString();
                textBoxJeuRep3.Text = currentQuest.reponses[2].reponse;
                textBoxJeuPoints3.Text = currentQuest.reponses[2].points.ToString();
                textBoxJeuRep4.Text = currentQuest.reponses[3].reponse;
                textBoxJeuPoints4.Text = currentQuest.reponses[3].points.ToString();
            }
            catch(Exception) { }
            
        }

        private void comboBoxOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Affichage des informations d'une question lorsqu'elle est sélectionnée dans la liste
            Question currentQuest = (Question)comboBoxOrientation.SelectedItem;

            richTextBoxJeu.Text = currentQuest.enonce;



            try
            {
                textBoxOrientRep1.Text = currentQuest.reponses[0].reponse;
                textBoxOrientPoints1.Text = currentQuest.reponses[0].points.ToString();
                textBoxOrientRep2.Text = currentQuest.reponses[1].reponse;
                textBoxOrientPoints2.Text = currentQuest.reponses[1].points.ToString();
                textBoxOrientRep3.Text = currentQuest.reponses[2].reponse;
                textBoxOrientPoints3.Text = currentQuest.reponses[2].points.ToString();
                textBoxOrientRep4.Text = currentQuest.reponses[3].reponse;
                textBoxOrientPoints4.Text = currentQuest.reponses[3].points.ToString();
            }
            catch (Exception) { }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Ne sert à rien je sais pas comment le supprimer...
        }

        private void buttonValiderEmail_Click(object sender, EventArgs e)
        {
            TravailClient.saveEmailConfig(textBoxURL.Text, textBoxPort.Text, textBoxCompte.Text, textBoxPass.Text);
        }

        private void buttonValiderJeu_Click(object sender, EventArgs e)
        {
            //Modifie ou créé une question de type Jeu
            Question currentQuestion = (Question)comboBoxJeu.SelectedItem;

            TravailClient.modifQuestion(currentQuestion.ID, richTextBoxJeu.Text, textBoxJeuRep1.Text, textBoxJeuPoints1.Text, textBoxJeuRep2.Text, textBoxJeuPoints2.Text, textBoxJeuRep3.Text, textBoxJeuPoints3.Text, textBoxJeuRep4.Text, textBoxJeuPoints4.Text);
            
        }

        private void buttonSupprJeu_Click(object sender, EventArgs e)
        {
            //Suppr une qustion de type Jeu
            Question currentQuestion = (Question)comboBoxJeu.SelectedItem;

            TravailClient.supprQuestion(currentQuestion.ID);
        }

        private void buttonValiderOrientation_Click(object sender, EventArgs e)
        {
            //Modifie ou créé une question de type Orientation
            Question currentQuestion = (Question)comboBoxOrientation.SelectedItem;

            TravailClient.modifQuestion(currentQuestion.ID, richTextBoxJeu.Text, textBoxJeuRep1.Text, textBoxJeuPoints1.Text, textBoxJeuRep2.Text, textBoxJeuPoints2.Text, textBoxJeuRep3.Text, textBoxJeuPoints3.Text, textBoxJeuRep4.Text, textBoxJeuPoints4.Text);
            
        }

        private void buttonSupprOrientation_Click(object sender, EventArgs e)
        {
            //Suppr une qustion de type Orientation
            Question currentQuestion = (Question)comboBoxOrientation.SelectedItem;

            TravailClient.supprQuestion(currentQuestion.ID);

            
        }
    }
}
