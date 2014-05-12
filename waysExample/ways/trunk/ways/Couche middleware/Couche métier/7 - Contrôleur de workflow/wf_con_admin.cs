using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;
using System.Data;
using System.Windows.Forms;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class wf_con_admin
    {
        private CAD oCAD;
        private MPG_Personne oMPG_pers;
        private CrypterMDP crypter;

        public wf_con_admin()
        {
            oCAD = new CAD();
            crypter = new CrypterMDP();
            oMPG_pers = new MPG_Personne();

        }
        public MSG con_admin(MSG msg)
        {
            msg.SetData("param1",crypter.EncrypterMDP(msg).GetData("mdp"));
            Console.WriteLine(msg.GetData("param1"));
            msg.SetData("msg1", "mdp");
            msg.SetData("msg2", "nom_personne");
            msg.SetData("param2", msg.GetData("log"));
            msg = oMPG_pers.m_select_personne(msg);
            msg = oCAD.ActionRows(msg);
            if (msg.GetData("dataset") != null)
            {
                msg.Statut = true;
            }
            return msg;
        }

    }
}
