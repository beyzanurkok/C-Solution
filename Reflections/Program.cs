﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var tip = typeof(DortIslem); //Parametre olarak verilen nesnenin tipini belirler.

            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7); // Parametrede verilen tipte bir nesne oluşturur.
            Console.WriteLine(dortIslem.Topla(4, 5));
            Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 7, 8);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); //  instance oluşturulup ile belirtilen metotun bilgisi  alındı.
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("-------------------------------------------");


            var metodlar = tip.GetMethods();

            foreach (var info in metodlar) // belirtilen tipin tüm metotları çağırıldı.
            {
                Console.WriteLine("Metotlar : " + info.Name); // çağırılan metotların isimleri listelendi.

                foreach (var parametre in info.GetParameters())
                {
                    Console.WriteLine("Parametreler : " + parametre.Name); // listelenen metotların parametrelerinin isimlerini listeler.
                }

                foreach (var attiribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : " + attiribute.GetType().Name);//metotların attiributeleri listelenir.
                }
            }



            Console.ReadLine();

        }

        class DortIslem
        {
            private int _sayi1;
            private int _sayi2;
            public DortIslem(int sayi1, int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;
            }

            public DortIslem()
            {
              
            }
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }

            public int Carp()
            {
                return _sayi1 * _sayi2;
            }
         

            public int Carp2(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
        }
    }
}
