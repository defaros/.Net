using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Reponse
    {
        //description d'une réponse avec ces points

        public string reponse;
        public int points;

        public Reponse(string newReponse, int newPoints)
        {
            this.points = newPoints;
            this.reponse = newReponse;
        }

        //Permet l'affichage dans les combobox
        public override string ToString()
        {
            return reponse;
        }


    }
}
