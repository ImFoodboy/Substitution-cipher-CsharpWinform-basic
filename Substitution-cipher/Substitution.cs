using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substitution_cipher
{
    class Substitution
    {
        private string key = "";
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public bool isNumber(char c)
        {
            return c < '0' || c > '9';
        }
        public bool isValidKey(string s)
        {
            key = "";
            key += s[0];
            for (int i = 1; i < s.Length; i++)
            {
                char c = Char.ToLower(s[i]);
                if (alphabet.IndexOf(c) == -1)
                {
                    return false;
                }
                else
                {
                    if (key.IndexOf(c) != 1)
                    {
                        key += c;
                    }
                    else
                    {
                        key = "";
                        return false;
                    }
                }
            }
            return true;
        }
        public bool SetKey(string s)
        {
            return isValidKey(s);
        }

        public string Encrypt(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                int i = alphabet.IndexOf(Char.ToLower(ch));
                if (i != -1)
                {
                    if (Char.IsUpper(ch))
                    {
                        result += Char.ToUpper(key[i]);
                    }
                    else
                    {
                        result += key[i];
                    }
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }

        public string Decrypt(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                int i = key.IndexOf(Char.ToLower(ch));
                if (i != -1)
                {
                    if (Char.IsUpper(ch))
                    {
                        result += Char.ToUpper(alphabet[i]);
                    }
                    else
                    {
                        result += key[i];
                    }
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }
    }
}
