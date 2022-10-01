using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SubstitutionCipher;

namespace SubstituteCipherTests
{
    [TestFixture]
    public class KeyGeneratorTest
    {
        private Key _key;
        public KeyGeneratorTest()
        {
            KeyGenerator generator = new KeyGenerator();
            _key = generator.Generate();
        }
        [Test]
        public void CountOfIncludedSubstitutes()
        {
            Assert.AreEqual(1024, _key.Substitutes.Count);
            
            bool KeyOk = true;
            List<char> usedChars = new List<char>();
            
        }
        [Test]
        public void OriginalityOfEachIncludedSubstitutes()
        {
            List<char> usedChars = new List<char>();
            foreach (var substitute in _key.Substitutes)
            {
                if (usedChars.Contains(substitute.Value))
                {
                    Assert.Fail();
                }
                else
                {
                    usedChars.Add(substitute.Value);
                }
            }
            Assert.Pass();
        }
        [Test]
        public void IncludesAnyRequiredLetters()
        {
            for (int i = 0; i < 1024; i++)
            {
                if (!_key.Substitutes.Keys.Contains((char)i))
                {
                    Assert.Fail();
                }
            }
            Assert.Pass();
        }
        
    }
}