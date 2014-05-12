using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ways.Couche_middleware._91___Service_etendu.Composant_accès_aux_données;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware.Couche_métier._9___Entité_de_mappage;

namespace ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow
{
    class m_ajt_question
    {
        private DataSet ds;
        private MSG oMSG;
        private String id;
        public void m_ajt_question_reponse(MSG msg)
        {   
            ds = new DataSet();
            oMSG = new MSG();
            CAD cad = new CAD();
            MPG_Question qr = new MPG_Question();
            MPG_Reponse rep = new MPG_Reponse();
            id = "";
            //Ajouter question///////////////////////////////////////////////////////////////////
            msg = qr.m_mpg_insert_question(msg);
            cad.ActionRows(msg);
            //Recupérer l'ID de la question ajoutée//////////////////////////////////////////////
            msg = qr.m_mpg_select_last_id_question(msg);
            oMSG = cad.GetRows(msg);
            ds = (DataSet)oMSG.GetData("dataset");
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        id = row[column].ToString();
                    }
                }
            }
            oMSG.SetData("id_question", id);
            //Ajouter les réponses////////////////////////////////////////////////////////////////)
            if (oMSG.GetData("@ouvertefermee").ToString() == "Oui")
            {
                    int nb = (int)oMSG.GetData("nb_rep");
                    if (nb.ToString().IndexOf("1") != -1)
                    {
                        oMSG.SetData("rep", msg.GetData("@rep1"));
                        if(msg.GetData("@type").ToString() == "1")
                        {
                            oMSG.SetData("type", msg.GetData("@type").ToString());
                            if (msg.GetData("@bar1").ToString() == "Web")
                                oMSG.SetData("bar", "1");

                            else if (msg.GetData("@bar1").ToString() == "Jeu Vidéo")
                                oMSG.SetData("bar", "2");

                            else if (msg.GetData("@bar1").ToString() == "Téléphonie")
                                oMSG.SetData("bar", "3");

                            else if (msg.GetData("@bar1").ToString() == "Chercheur")
                                oMSG.SetData("bar", "4");

                            else if (msg.GetData("@bar1").ToString() == "Architecte SI")
                                oMSG.SetData("bar", "5");

                            else if (msg.GetData("@bar1").ToString() == "Chef de projet")
                                oMSG.SetData("bar", "6");
                        }
                        else if (msg.GetData("@type").ToString() == "3"){
                            oMSG.SetData("type", "3");
                            oMSG.SetData("bar", msg.GetData("@bar1").ToString());
                        }
                        //////////////////REQUETTE////////////////////
                        msg = rep.m_mpg_insert_reponse(oMSG);
                        cad.ActionRows(msg);
                    }
                    if (nb.ToString().IndexOf("2") != -1)
                    {
                        oMSG.SetData("rep", msg.GetData("@rep2"));
                        if (msg.GetData("@type").ToString() == "1")
                        {
                            oMSG.SetData("type", msg.GetData("@type").ToString());
                            if (msg.GetData("@bar2").ToString() == "Web")
                                oMSG.SetData("bar", "1");

                            else if (msg.GetData("@bar2").ToString() == "Jeu Video")
                                oMSG.SetData("bar", "2");

                            else if (msg.GetData("@bar2").ToString() == "Téléphonie")
                                oMSG.SetData("bar", "3");

                            else if (msg.GetData("@bar2").ToString() == "Chercheur")
                                oMSG.SetData("bar", "4");

                            else if (msg.GetData("@bar2").ToString() == "Architecte SI")
                                oMSG.SetData("bar", "5");

                            else if (msg.GetData("@bar2").ToString() == "Chef de projet")
                                oMSG.SetData("bar", "6");
                        }
                        else if (msg.GetData("@type").ToString() == "3")
                        {
                            oMSG.SetData("type", "3");
                            oMSG.SetData("bar", msg.GetData("@bar2").ToString());
                        }
                        //////////////////REQUETTE////////////////////
                        msg = rep.m_mpg_insert_reponse(oMSG);
                        cad.ActionRows(msg);
                    }
                    if (nb.ToString().IndexOf("3") != -1)
                    {
                        oMSG.SetData("rep", msg.GetData("@rep3"));
                        if (msg.GetData("@type").ToString() == "1")
                        {
                            oMSG.SetData("type", msg.GetData("@type").ToString());
                            if (msg.GetData("@bar3").ToString() == "Web")
                                oMSG.SetData("bar", "1");

                            else if (msg.GetData("@bar3").ToString() == "Jeu Video")
                                oMSG.SetData("bar", "2");

                            else if (msg.GetData("@bar3").ToString() == "Téléphonie")
                                oMSG.SetData("bar", "3");

                            else if (msg.GetData("@bar3").ToString() == "Chercheur")
                                oMSG.SetData("bar", "4");

                            else if (msg.GetData("@bar3").ToString() == "Architecte SI")
                                oMSG.SetData("bar", "5");

                            else if (msg.GetData("@bar3").ToString() == "Chef de projet")
                                oMSG.SetData("bar", "6");
                        }
                        else if (msg.GetData("@type").ToString() == "3")
                        {
                            oMSG.SetData("type", "3");
                            oMSG.SetData("bar", msg.GetData("@bar3").ToString());
                        }
                        //////////////////REQUETTE////////////////////
                        msg = rep.m_mpg_insert_reponse(oMSG);
                        cad.ActionRows(msg);
                    }
                    if (nb.ToString().IndexOf("4") != -1)
                    {
                        oMSG.SetData("rep", msg.GetData("@rep4"));
                        if (msg.GetData("@type").ToString() == "1")
                        {
                            oMSG.SetData("type", msg.GetData("@type").ToString());
                            if (msg.GetData("@bar4").ToString() == "Web")
                                oMSG.SetData("bar", "1");

                            else if (msg.GetData("@bar4").ToString() == "Jeu Video")
                                oMSG.SetData("bar", "2");

                            else if (msg.GetData("@bar4").ToString() == "Téléphonie")
                                oMSG.SetData("bar", "3");

                            else if (msg.GetData("@bar4").ToString() == "Chercheur")
                                oMSG.SetData("bar", "4");

                            else if (msg.GetData("@bar4").ToString() == "Architecte SI")
                                oMSG.SetData("bar", "5");

                            else if (msg.GetData("@bar4").ToString() == "Chef de projet")
                                oMSG.SetData("bar", "6");
                        }
                        else if (msg.GetData("@type").ToString() == "3")
                        {
                            oMSG.SetData("type", "3");
                            oMSG.SetData("bar", msg.GetData("@bar4").ToString());
                        }
                        //////////////////REQUETTE////////////////////
                        msg = rep.m_mpg_insert_reponse(oMSG);
                        cad.ActionRows(msg);
                    }
            }
        }
    }
}
