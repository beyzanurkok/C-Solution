using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringIntro();
            //StringMethods();
            Console.ReadLine();

        }

        private static void StringMethods()
        {
            string sentence = "My name is Beyzanur Kök";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Ömer Faruk Kök";

            bool result3 = sentence.EndsWith("k");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace("m", "o");
            var result13 = sentence.Remove(2, 5);

            Console.WriteLine(result13);
        }

        private static void StringIntro()
        {
            string city = "Samsun";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;

            // Console.WriteLine(result);
            Console.WriteLine(city + city2);
            Console.WriteLine("{0} {1}", city, city2);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
