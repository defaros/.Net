using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._4___Composant_serveur;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._3___Composant_utilisateur_de_connexion
{
    class CUC
    {
        private CS oCS;

        public CUC()
        {
            oCS = new CS();
        }

        public MSG con_ToCS(MSG msg)
        {
            msg.AppName = "ways";
            msg = oCS.con_platforme(msg);
            return msg;
        }

    }
}
