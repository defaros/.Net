using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Client.Composant_utilisateur_de_communication
{
    public class Classement
    {
        //Liste d'users formant un classement
        public BindingList<User> users { get; set; }

        public Classement(BindingList<User> users)
        {
            this.users = users;
        }

    }
}
