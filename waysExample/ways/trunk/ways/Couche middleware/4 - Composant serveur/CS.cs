using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using ways.Couche_middleware._5___Groupe_de_processus;
using System.Reflection;

namespace ways.Couche_middleware._4___Composant_serveur
{
    /// <summary>
    /// 
    /// </summary>
    class CS
    {
        private string namespacecible;

        public CS()
        {
            namespacecible = "ways.Couche_middleware._5___Groupe_de_processus";
        }
        public MSG con_platforme(MSG msg)
        {
            if(msg.AppName == "ways")
            {
                if (!string.IsNullOrEmpty(msg.Invoke))
                {
                    string[] split_Invoke = msg.Invoke.Split(new char[] { '.' });
                    if (split_Invoke.Length >= 2)
                    {
                        string classeApp = split_Invoke[0];
                        string methodeApp = split_Invoke[1];

                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Type typeClasse = assembly.GetType(namespacecible + "."+ classeApp);
                        if (typeClasse != null)
                        {
                            object classe = Activator.CreateInstance(typeClasse);
                            MethodInfo methode = typeClasse.GetMethod(methodeApp);
                            msg = (MSG)methode.Invoke(classe, new[] { msg });

                        }
                        else
                        {
                            msg.Statut = false;
                            msg.Info = "La classe demandé n'a pas été trouvé";
                        }
                    }
                    else
                    {
                        msg.Statut = false;
                        msg.Info = "la variable invoke contient plus d'un '.' veuillez vérifier votre variable";
                    }

                }
                else
                {
                    msg.Statut = false;
                    msg.Info = "La variable invoke est vide veuillez verifier";
                }
            }
            else
            {
                msg.Statut = false;
                msg.Info = "l'application n'a pas accès à la platforme";
            }
            return msg;
        }
        
    }
}
