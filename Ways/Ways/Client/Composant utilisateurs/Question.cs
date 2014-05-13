using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateurs
{
    class Question
    {

        public string enonce;

        public string type;

        public Reponse[] reponses;


        public Question(string enonce, string type, Reponse[] reponses)
        {
            this.enonce = enonce;
            this.type = type;
            this.reponses = reponses;
        }

    }
}
