using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Filiere
    {
        //Description d'un metier (ou filière)
        public string name;

        public string description;

        public int miniScore;

        public int maxiScore;


        public override string ToString()
        {
            return name;
        }
    }
}
