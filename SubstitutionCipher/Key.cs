using System;
using System.Collections.Generic;

namespace SubstitutionCipher
{
    public class Key
    {
        public List<int> Scammers { get; set; }
        public Dictionary<char, char> Substitutes { get; set; }

        public Key()
        {
            Scammers = new List<int>();
            Substitutes = new Dictionary<char, char>();
        }
    }
}