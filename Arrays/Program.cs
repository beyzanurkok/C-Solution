using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[4];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Beyza";

            string[] students2 = {"ben", "sen", "o" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "İstanbul","izmir","balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Samsun","Trabzon","Rize"},
                { "İzmir","Muğla","Manisa"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("-------------------------------");
            }

            Console.ReadLine();
        }
    }
}
