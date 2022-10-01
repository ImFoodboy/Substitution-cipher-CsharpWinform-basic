using System;
using System.Text;

namespace SubstitutionCipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            KeyGenerator generator = new KeyGenerator();
            var key = generator.Generate(50);
            var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis, turpis sit amet placerat placerat, erat sem mattis lacus, viverra cursus risus sapien in lectus. Quisque egestas consequat est at sollicitudin. In eu blandit est, non mattis odio. Cras odio sapien, volutpat at arcu ac, efficitur lacinia eros. Proin scelerisque aliquet diam, id malesuada tortor pharetra at. Maecenas magna urna, vulputate eu egestas nec, venenatis nec dolor. Maecenas viverra ex vitae orci placerat, varius aliquet tortor dignissim. Suspendisse potenti. Quisque placerat mattis facilisis.";
            var encrypted = Processor.Encrypt(text, key);
            var decrypted = Processor.Decrypt(encrypted, key);
             Console.WriteLine(text.Length);
             Console.WriteLine(text);
             Console.WriteLine(encrypted.Length);
             Console.WriteLine(text);
             Console.WriteLine(encrypted);
             Console.WriteLine(decrypted);
    }
    }
}