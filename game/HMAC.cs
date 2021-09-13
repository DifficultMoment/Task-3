using System;
using System.Security.Cryptography;
using System.Text;

namespace game
{
    class HMAC
    {
        public string GenerateHMAC(string computerTurn, string key) {
            var hmac = new HMACSHA256(Encoding.Default.GetBytes(key));
            var turn = hmac.ComputeHash(Encoding.Default.GetBytes(computerTurn));
            return BitConverter.ToString(turn).Replace("-", string.Empty).ToLower();
        }
    }
}
