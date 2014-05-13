using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class User
    {
        //User posedant un score et un plassement dans un classement

        string name;
        int score;
        int placement;

        public User(string NewName)
        {
            this.name = NewName;
            this.score = 0;
            this.placement = 0;
        }

        public User(string NewName, int score, int placement)
        {
            this.name = NewName;
            this.score = score;
            this.placement = placement;
        }

        public void setScore(int score, int placement)
        {
            this.score = score;
            this.placement = placement;
        }

        //Permet l'affichage dans les combobox
        public override string ToString()
        {
            return name;
        }

    }
}
