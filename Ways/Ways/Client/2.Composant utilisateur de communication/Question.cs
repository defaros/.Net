using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Question
    {
        //Enoncé, réponses et type d'une question
        public int ID;

        public string enonce;

        public string type;

        public Reponse[] reponses;


        public Question(int ID, string enonce, string type, Reponse[] reponses)
        {
            this.ID = ID;
            this.enonce = enonce;
            this.type = type;
            this.reponses = reponses;
        }


        //Permet l'affichage dans les combobox
        public override string ToString()
        {
            return enonce;
        }

    }
}
