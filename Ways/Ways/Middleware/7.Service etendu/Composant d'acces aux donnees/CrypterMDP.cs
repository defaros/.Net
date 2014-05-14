using CryptAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ways.Middleware.Service_etendu.Composant_d_acces_aux_donnees
{
    class CrypterMDP
    {

        public MSG EncrypterMDP(MSG msg)
        {
            CryptServiceProvider provider = new CryptServiceProvider(Algorithm.MD5);
            CryptAPI.HashAlgorithm md5 = provider.GetCryptServiceProvider();
            msg.SetData("mdp", md5.Encrypt((string)msg.GetData("mdp")));
            return msg;
        }
    }
}
