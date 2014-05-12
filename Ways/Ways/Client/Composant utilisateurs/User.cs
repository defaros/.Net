using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateurs
{
    class User
    {

        string name;
        int score;
        int placement;

        public User(string NewName)
        {
            this.name = NewName;
            this.score = 0;
            this.placement = 0;
        }

        public void setScore(int score, int placement)
        {
            this.score = score;
            this.placement = placement;
        }

    }
}
