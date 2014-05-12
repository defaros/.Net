using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_client._3___Composant_utilisateur_de_connexion;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_score_jeu
    {
        private int score;
        private MSG oMSG;
        private CUC oCUC;

        public CUT_score_jeu()
        {
            score = 0;
            oMSG = new MSG();
            oCUC = new CUC();
        }

        public void ajout_score(MSG msg)
        {
            score = score + (int)msg.GetData("points");
            Console.WriteLine(msg.GetData("points") + "  score = " + score);
        }
        public MSG score_final()
        {
            oMSG.SetData("score", score);
            return oMSG;
        }
    }
}
