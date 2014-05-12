using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    public class Ajout_info_perso_visiteur_wf
    {
         #region Variables de classe


         #endregion

        #region Méthodes

        public void wf_ajout_info_perso_visiteur(MSG msg)
        {
            // instancier la classe de mappage a appeler
            MPG_Personne mpg_personne = new MPG_Personne();
            mpg_personne.m_insert_personne(msg);
            CAD cad = new CAD();
            cad.ActionRows(msg);
            msg.Statut = true;
        }

        #endregion

        #region Assesseurs



        #endregion
    }
}
