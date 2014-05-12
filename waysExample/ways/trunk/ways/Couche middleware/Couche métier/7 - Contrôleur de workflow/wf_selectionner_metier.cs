using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_selectionner_metier
    {
        private MPG_Metier oMPG;
        private CAD oCAD;

        public wf_selectionner_metier()
        {
            oMPG = new MPG_Metier();
            oCAD = new CAD();
        }

        public MSG recuperer_metier(MSG msg)
        {
            msg.SetData("param1", msg.GetData("id_metier"));
            msg.SetData("msg1", "id_metier");
            msg = oMPG.m_select_metier(msg);
            msg = oCAD.GetRows(msg);
            return msg;
        }
    }
}
