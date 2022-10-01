using System;
using System.Text;

namespace SubstitutionCipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            KeyGenerator generator = new KeyGenerator();
            var key = generator.Generate();
            var text =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum sagittis, turpis sit amet placerat placerat, erat sem mattis lacus, viverra cursus risus sapien in lectus. Quisque egestas consequat est at sollicitudin. In eu blandit est, non mattis odio. Cras odio sapien, volutpat at arcu ac, efficitur lacinia eros. Proin scelerisque aliquet diam, id malesuada tortor pharetra at. Maecenas magna urna, vulputate eu egestas nec, venenatis nec dolor. Maecenas viverra ex vitae orci placerat, varius aliquet tortor dignissim. Suspendisse potenti. Quisque placerat mattis facilisis.\n Cras maximus ante risus, quis elementum elit elementum ut. Sed dapibus egestas nisi, eget semper tortor rhoncus vitae. Nam eleifend vehicula neque a tincidunt. Cras convallis malesuada elit, vel faucibus nisl sodales at. Pellentesque fringilla sem erat. Quisque dignissim sit amet mauris laoreet efficitur. Maecenas leo sem, aliquam ac sapien in, interdum sagittis sem. Aliquam risus libero, gravida in justo eu, pellentesque consectetur lectus. Nulla a est placerat, varius sem ac, cursus enim. Cras porta elit nec est rutrum, non ullamcorper magna maximus. Donec imperdiet, massa vel tristique molestie, mauris ante accumsan sem, in viverra tortor mauris nec justo. Duis a sodales elit, ut facilisis leo. Nullam vel mauris gravida, luctus justo in, tincidunt mauris. Mauris eu est purus. Nam congue at nibh sed scelerisque.\n Maecenas elementum velit at lectus blandit eleifend. Quisque semper aliquam dui, in commodo lectus semper vehicula. Maecenas ornare sapien ultrices semper sagittis. Pellentesque ac nunc lectus. Sed eleifend pharetra dui at porta. Maecenas turpis lorem, consequat scelerisque velit quis, pharetra hendrerit tellus. Phasellus et porttitor velit, nec fermentum felis.\n Mauris interdum metus urna, luctus commodo lacus hendrerit et. Donec lacus ipsum, consectetur venenatis consectetur eu, gravida vitae justo. Ut non ornare metus, sed pharetra augue. Nunc sit amet massa ex. Integer euismod egestas maximus. Maecenas semper purus pharetra, tempus nunc vel, malesuada nisi. Aenean eget vulputate mi. Praesent tristique enim nec tellus varius volutpat. Nunc condimentum nisl auctor felis tempus, in sagittis elit pulvinar. Morbi odio ipsum, molestie sit amet congue sit amet, consectetur ut massa. Mauris magna odio, congue quis quam eget, tempor porttitor dolor. Suspendisse potenti.\n Aenean tellus ipsum, accumsan a lacus in, viverra pharetra nunc. Vestibulum vestibulum posuere massa, vitae dignissim purus ultricies a. Nulla gravida eget lorem in rhoncus. Vestibulum ultrices enim consectetur est ultricies porta. Vestibulum consequat nisi vel tortor vehicula, et auctor nisl lobortis. Aliquam et felis vel tellus facilisis convallis. Maecenas fermentum a urna in aliquet. Vestibulum consequat, metus a vestibulum cursus, magna mi maximus purus, quis sagittis lorem massa ut purus. Ut maximus sem ac lectus volutpat porta. Quisque fermentum vel ex et auctor. Suspendisse id lobortis orci. Vestibulum eget tincidunt sapien. Ut porta, massa non convallis fringilla, diam lacus feugiat nulla, a accumsan lorem tortor a urna.";
            //var text = "ahoj ahoj ahoj";
            CipherProcessor processor = new CipherProcessor();
            var encrypted = processor.Encrypt(text, key);
            var decrypted = processor.Decrypt(encrypted, key);
            Console.WriteLine(text.Length);
            Console.WriteLine(text);
            Console.WriteLine(encrypted.Length);
            Console.WriteLine(text);
            Console.WriteLine(encrypted);
            Console.WriteLine(decrypted);
            
            Console.WriteLine(text == decrypted);
        }
    }
}