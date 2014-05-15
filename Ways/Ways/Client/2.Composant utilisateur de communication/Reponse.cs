using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Reponse
    {
        //description d'une réponse avec ses points

        public int ID;
        public string reponse;
        public int points;

        public Reponse(string reponse, int points, int ID)
        {
            this.points = points;
            this.reponse = reponse;
            this.ID = ID;
        }

        //Permet l'affichage dans les combobox
        public override string ToString()
        {
            return reponse;
        }


    }
}
