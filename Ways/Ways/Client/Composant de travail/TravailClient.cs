using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ways.Middleware.Metier.Mappage;

namespace Ways.Client.Composant_de_travail
{
    class TravailClient
    {

        public static bool verifSurnom(string name)
        {
            if(name == null)
            {
                return false;
            }
            else if (isThatNameAlreadyUse(name))
            {
                return false;
            }
            else
            {
                return true;
            }

        }



        public static bool isThatNameAlreadyUse(string name)
        {
            string[] allNames = Requetes.getAllNames();

            foreach (string varName in allNames)
            {
                if (name == varName)
                {
                    return false;
                }
            }

            return false;
        }

    }
}
