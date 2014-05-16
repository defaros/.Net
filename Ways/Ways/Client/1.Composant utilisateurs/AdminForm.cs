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
        Reponse[] tableauReps;
        Question newQuest;
        public AdminForm(List<Question> questionsJeu, List<Question> questionsOrientation, string[] paramEmail)
        {

            afficherDonnees(questionsJeu,questionsOrientation,paramEmail);


            
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

            richTextBoxOrientation.Text = currentQuest.enonce;



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

            TravailClient.modifQuestion(currentQuestion.ID, richTextBoxJeu.Text, "Jeu", textBoxJeuRep1.Text, textBoxJeuPoints1.Text, textBoxJeuRep2.Text, textBoxJeuPoints2.Text, textBoxJeuRep3.Text, textBoxJeuPoints3.Text, textBoxJeuRep4.Text, textBoxJeuPoints4.Text);
            

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

            TravailClient.modifQuestion(currentQuestion.ID, richTextBoxOrientation.Text, "Orientation", textBoxOrientRep1.Text, textBoxOrientPoints1.Text, textBoxOrientRep2.Text, textBoxOrientPoints2.Text, textBoxOrientRep3.Text, textBoxOrientPoints3.Text, textBoxOrientRep4.Text, textBoxOrientPoints4.Text);
            
        }

        private void buttonSupprOrientation_Click(object sender, EventArgs e)
        {
            //Suppr une qustion de type Orientation
            Question currentQuestion = (Question)comboBoxOrientation.SelectedItem;

            TravailClient.supprQuestion(currentQuestion.ID);

            
        }

        public void afficherDonnees(List<Question> questionsJeu, List<Question> questionsOrientation, string[] paramEmail)
        {
            tableauReps = new Reponse[4] { new Reponse(null, 0, 0), new Reponse(null, 0, 0), new Reponse(null, 0, 0), new Reponse(null, 0, 0) };
            newQuest = new Question(-1, "Nouvelle question", null, tableauReps);
            InitializeComponent();
            //Initialisation textBox email

            textBoxURL.Text = paramEmail[0];
            textBoxPort.Text = paramEmail[1];
            textBoxCompte.Text = paramEmail[2];
            textBoxPass.Text = paramEmail[3];


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
    }
}
