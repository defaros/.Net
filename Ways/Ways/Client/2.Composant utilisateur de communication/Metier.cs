using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Metier
    {
        //Description d'un metier (ou filière)
        string name;

        string description;


        public override string ToString()
        {
            return name;
        }
    }
}
