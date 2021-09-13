using System;
using System.Security.Cryptography;

namespace game
{
    class Key
    {
        public string GenerateKey() {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[10];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
    }
}
