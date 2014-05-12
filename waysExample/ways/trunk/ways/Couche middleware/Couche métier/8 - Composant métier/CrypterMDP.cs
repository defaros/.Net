using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CryptAPI;
namespace ways.Couche_middleware.Couche_métier._8___Composant_métier
{
    class CrypterMDP
    {
        
        public MSG EncrypterMDP(MSG msg)
        {
            CryptServiceProvider provider = new CryptServiceProvider(Algorithm.MD5);
            HashAlgorithm md5 = provider.GetCryptServiceProvider();
            msg.SetData("mdp",md5.Encrypt((string)msg.GetData("mdp")));
            return msg;
        }
    }
}
