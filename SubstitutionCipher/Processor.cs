using System;
using System.Linq;

namespace SubstitutionCipher
{
    public class Processor
    {
        public static string Encrypt(string original, Key key)
        {
            Random random = new Random();
            string encrypted = String.Empty;

            foreach (var originalChar in original)
            {
                encrypted += key.Substitutes[originalChar];
            }

            for (int i = 0; i < original.Length; i++)
            {
                if(random.Next(0,5000)>4000)
                {
                    key.Scammers.Add(i);
                    char scammer = (char)random.Next(0, 1023);
            
                    string s1 = encrypted.Substring(0, i);
                    string s2 = encrypted.Substring(i, (encrypted.Length-(i)));
                    encrypted = s1 + scammer + s2;
                }
            }
            key.Scammers = key.Scammers.OrderByDescending(x => x).ToList();
            return encrypted;
        }

        public static string Decrypt(string crypted, Key key)
        {
            string decrypted = String.Empty;

            foreach (var scammer in key.Scammers)
            {
                string s1 = crypted.Substring(0, scammer);
                string s2 = crypted.Substring(scammer+1, (crypted.Length-(scammer+1)));
                crypted = s1 + s2;
            }
            
            foreach (var cryptedChar in crypted)
            {
                decrypted += key.Substitutes.FirstOrDefault(x => x.Value == cryptedChar).Key;
            }

            return decrypted;
        }
    }
}