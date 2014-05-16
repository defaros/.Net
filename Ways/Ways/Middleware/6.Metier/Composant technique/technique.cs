using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Ways.Client.Composant_utilisateur_de_communication;
using Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees;

namespace Ways.Middleware.Metier.Composant_technique
{
    class technique
    {
        //Effectue les calculs


        /*****************************************************Email****************************************************************/
        public static void saveEmailConfig(string host, string port, string compte, string mdp)
        {
            //le truc avec le XML
            MSG oMsg = new MSG();
            oMsg.SetData("host", host);
            oMsg.SetData("port", port);
            oMsg.SetData("compte", compte);
            oMsg.SetData("pwd", mdp);

            XML xml = new XML();
            xml.WriteConfigSmtpCrypted(oMsg);
        }

        



        public static int calculScore(List<Reponse> reps)
        {
            int scoreTotal = 0;
            foreach(Reponse rep in reps)
            {
                scoreTotal += rep.points;
            }

            return scoreTotal;
        }



        

    }
}
