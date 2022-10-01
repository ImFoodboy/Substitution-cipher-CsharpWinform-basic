using System;
using System.Collections.Generic;
using NUnit.Framework;
using SubstitutionCipher;

namespace SubstituteCipherTests
{
    [TestFixture]
    public class CipherProcessorTests
    {
        [Test]
        public void AddingScammers()
        {
            Key key = new Key();
            CipherProcessor processor = new CipherProcessor();
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            var textWithScammers = processor.AddScammers(text, key, new Random(), text);
            foreach (var scammer in key.Scammers)
            {
                if (text[scammer] == textWithScammers[scammer])
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }

        [Test]
        public void RemovingScammers()
        {
            Key key = new Key();
            CipherProcessor processor = new CipherProcessor();
            var original = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            var crypted = "Lorem8 ipsum6 dolor8 sit5 a4met4, consectetur4 adipiscing4 el4it.";
            key.Scammers.Add(12);
            key.Scammers.Add(5);
            key.Scammers.Add(19);
            key.Scammers.Add(24);
            key.Scammers.Add(27);
            key.Scammers.Add(31);
            key.Scammers.Add(45);
            key.Scammers.Add(57);
            key.Scammers.Add(61);
            var textWithoutScammers = processor.RemoveScammers(crypted, key);
            
            Assert.AreEqual(original, textWithoutScammers);
        }

        [Test]
        public void EncryptingText()
        {
            Key key = new Key();
            CipherProcessor processor = new CipherProcessor();
            var original = "ema ma maso";
            key.Substitutes.Add('e','q');
            key.Substitutes.Add('m','u');
            key.Substitutes.Add('a','e');
            key.Substitutes.Add(' ','r');
            key.Substitutes.Add('s','t');
            key.Substitutes.Add('o','y');

            var encrypted = processor.EncryptText(original, key,String.Empty);
            Assert.AreEqual("querueruety", encrypted);
        }

        [Test]
        public void DecryptingText()
        {
            Key key = new Key();
            CipherProcessor processor = new CipherProcessor();
            var original = "querueruety";
            key.Substitutes.Add('e','q');
            key.Substitutes.Add('m','u');
            key.Substitutes.Add('a','e');
            key.Substitutes.Add(' ','r');
            key.Substitutes.Add('s','t');
            key.Substitutes.Add('o','y');

            var encrypted = processor.DecryptText(original, key,String.Empty);
            Assert.AreEqual("ema ma maso", encrypted);
        }
        
        [Test]
        public void IntegrityTest()
        {
            KeyGenerator generator = new KeyGenerator();
            Key key = generator.Generate();
            CipherProcessor processor = new CipherProcessor();
            var original = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            var encrypted = processor.Encrypt(original, key);
            var decrypted = processor.Decrypt(encrypted, key);
            Assert.AreEqual(original, decrypted);
        }
    }
}