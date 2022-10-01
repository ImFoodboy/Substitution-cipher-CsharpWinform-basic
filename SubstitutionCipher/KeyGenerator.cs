using System;
using System.Collections.Generic;

namespace SubstitutionCipher
{
    public class KeyGenerator
    {
        private Key _key;
        private Random _random;

        public KeyGenerator()
        {
            _key = new Key();
            _random = new Random();
        }

        public Key Generate()
        {
            GenerateKeys();
            return _key;
        }

        private void GenerateKeys()
        {
            List<int> usedSubstitutes = new List<int>();
            for (int i = 0; i < 1024; i++)
            {
                int substitute = 0;
                do
                {
                    substitute = _random.Next(0, 1024);
                    
                } while (usedSubstitutes.Contains(substitute) || i == substitute);
                usedSubstitutes.Add(substitute);
                _key.Substitutes.Add((char)i, (char)substitute);
            }
        }
    }
}