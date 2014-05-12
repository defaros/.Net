using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ways.Couche_middleware.Couche_métier._8___Composant_métier
{
    /// <summary>
    /// Cette methode sera le seul objet utilisé pour les communication de methodes.
    /// Variables :
    ///     <string>appName</string>  :  permet à la plateforme d'identifier l'application appelante.
    ///     <string>invoke</string> : nom du service appelé.
    ///     <string>pSecurity</string> : permet aux appli de s'identifier auprès de la plateforme.
    ///     <bool>statut</bool> : permet au récepteur d'indiquer au destinataire si le traitement de l'opération demandé est un succès ou pas.
    ///     <string>info</string> : permet de divulguer des infos générales 
    ///     <string>token</string> : renseignée initialement lorsque l’utilisateur se connecte. Un utilisateur obtiendra un ‘token’ (une clé) qui lui permettra d’invoquer certains services mais pas forcément tous les services offerts par la plateforme.
    ///     <string>data</string> : Contient toutes les données.
    /// Methodes :
    ///     ToString() : 
    ///             Retourne toutes les données contenues dans data sous forme d'une chaîne de caractère.
    ///             return : string -> Données.        
    ///     DataExist(string key) : 
    ///             Test si une valeur exist dans le hashtable.
    ///             <param type ="string">key</param> -> valeur a tester.
    ///             return : bool.
    /// </summary>
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
