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

        public int Place { get; set; }
        public string Nom { get; set; }
        public int Score { get; set; }
        public User(string NewName)
        {
            this.Nom = NewName;
            this.Score = 0;
            this.Place = 0;
        }

        public User(string NewName, int score, int placement)
        {
            this.Nom = NewName;
            this.Score = score;
            this.Place = placement;
        }

        //Permet l'affichage dans les combobox
        public override string ToString()
        {
            return Nom;
        }

    }
}
