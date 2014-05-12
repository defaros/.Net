using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using ways.Couche_middleware.Couche_métier._8___Composant_métier;

namespace ways.Couche_client._2___Composant_utilisateur_de_travail
{
    class CUT_orient_presentation
    {
        public const string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                                 + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                                 + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                                 + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        public static bool IsEmail(MSG msg)
        {
            if (msg.GetData("mail") != null) return Regex.IsMatch(msg.GetData("mail").ToString(), MatchEmailPattern);
            else return false;
        }

        public static bool IsFully(MSG msg)
        {
            if (msg.GetData("nom").ToString() == "" || msg.GetData("prenom").ToString() == "" || msg.GetData("adresse").ToString() == "" || msg.GetData("mail").ToString() == "" || msg.GetData("telephone").ToString() == "" || msg.GetData("date_de_naissance").ToString() == "  /  /") 
                return false;
            else return true;
        }
    }
}
