using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    class Crypt
    {
        private const string sSecretKey = "Password"; // Clé utilisée pour crypter les données


        /* Fonction qui crypte une chaîne de caractères */
        public static string Encrypt(string original)
        {
            MD5CryptoServiceProvider hashMd5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = hashMd5.ComputeHash(
            UnicodeEncoding.Unicode.GetBytes(sSecretKey));

            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = passwordHash;

            des.Mode = CipherMode.ECB;

            byte[] buffer = UnicodeEncoding.Unicode.GetBytes(original);

            return UnicodeEncoding.Unicode.GetString(
            des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));

        }

        /* Fonction qui décrypte une chaîne encryptée */
        public static String Decrypt(string StringToDecrypt)
        {

            String StringDecrypted = "";
            MD5CryptoServiceProvider hashMd5 = new MD5CryptoServiceProvider();
            byte[] passwordHash = hashMd5.ComputeHash(
            UnicodeEncoding.Unicode.GetBytes(sSecretKey));

            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = passwordHash;
            des.Mode = CipherMode.ECB;

            byte[] buffer = UnicodeEncoding.Unicode.GetBytes(StringToDecrypt);
            StringDecrypted = UnicodeEncoding.Unicode.GetString(
            des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));

            return StringDecrypted;

        }


    }
}
