using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;
using System.Reflection;

namespace ways.Couche_middleware._6___Composant_accès_métier
{
    class CAM
    {
        private string namespacecible;

        public CAM()
        {
            namespacecible = "ways.Couche_middleware.Couche_métier._7___Contrôleur_de_workflow";
        }
        public MSG go_to_wf(MSG msg)
        {
            //if (msg.Token == "Grp_procesusWays")
            //{
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
                    }
                }
            //}
            return msg;
        }
    }
}
