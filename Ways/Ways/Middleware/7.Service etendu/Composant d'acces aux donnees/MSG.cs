using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    public class MSG
    {
        // Structure générale d'envoi des fonctions du programme.
        #region Variables de classe

        private string appName;
        private string invoke;
        private string pSecurity;
        private bool statut;
        private string info;
        private string token;
        private Hashtable data;

        #endregion

        public MSG()
        {
            // Initialisation des variables d'instance.
            this.appName = "";
            this.invoke = "";
            this.pSecurity = "";
            this.statut = false;
            this.info = "";
            this.token = "";
            this.data = new Hashtable();
        }


        #region Méthodes

        public override string ToString()
        {
            string resultat = "-----------------------\n";
            resultat += "appName : " + this.appName + "(" + this.appName.GetType().Name + ")" + "\n";
            resultat += "invoke : " + this.invoke + "(" + this.invoke.GetType().Name + ")" + "\n";
            resultat += "pSecurity : " + this.pSecurity + "(" + this.pSecurity.GetType().Name + ")" + "\n";
            resultat += "statut : " + this.statut + "(" + this.statut.GetType().Name + ")" + "\n";
            resultat += "info : " + this.info + "(" + this.info.GetType().Name + ")" + "\n";
            resultat += "token : " + this.token + "(" + this.token.GetType().Name + ")" + "\n";

            IDictionaryEnumerator iEnum = this.data.GetEnumerator();
            resultat += "data : \n";
            while (iEnum.MoveNext())
            {
                resultat += " --- '" + iEnum.Key + "' : " + iEnum.Value + "(" + iEnum.Value.GetType().Name + ")\n";
            }
            resultat += "-----------------------\n";
            return resultat;
        }

        public bool DataExist(string key)
        {
            if (this.data.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Assesseurs

        public bool Statut
        {
            get { return statut; }
            set { statut = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public void SetData(string key, object value)
        {
            if (this.data.ContainsKey(key))
            {
                this.data.Remove(key);
                this.data.Add(key, value);
            }
            else
            {
                this.data.Add(key, value);
            }
        }

        public object GetData(string key)
        {
            return this.data[key];
        }

        public void SetDatas(Hashtable datas)
        {
            this.data = datas;
        }

        public string AppName
        {
            get { return appName; }
            set { appName = value; }
        }

        public string Invoke
        {
            get { return invoke; }
            set { invoke = value; }
        }

        public string PSecurity
        {
            get { return pSecurity; }
            set { pSecurity = value; }
        }

        public string Token
        {
            get { return token; }
            set { token = value; }
        }
        #endregion

    }
}
