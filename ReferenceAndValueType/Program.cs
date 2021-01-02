using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);
            Console.ReadLine();

            string[] cities1 = new string[] { "Samsun", "Ankara", "Bursa" };//bu nesnenin bellektekini yerini 101 varsayalım.
            string[] cities2 = new string[] { "Sakarya", "İstanbul", "Van" };//bu nesnenin bellektekini yerini 102 varsayalım.

            cities2 = cities1;  // artık cities2 nin bellekte gösterdiği yer de 101dir. 102 nolu kısım çöptoplayıcılar tarafından atılır.
            cities1[0] = "Burdur";

            Console.WriteLine(cities2[0]);


        }
    }
}
