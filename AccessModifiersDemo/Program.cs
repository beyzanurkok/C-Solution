using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;
namespace AccessModifiersDemo
{
    class Program /* Course2 farklı bir projede yer alan bir classtır.Burada tanımlayabilmek için 
                     Mevcut projeye referans olarak kullanılmak istenen class ın bulunduğu 
                     proje verilir.Sonrasında eklenilmek istenen class ın kütüphanesine eklenir.Ve 
                     kullanılmak istenen class public olarak seçilir.*/
    {
        static void Main(string[] args)
        {
            Course2 course = new Course2();  // Başka bir projede bulunan Course2 classına erişildi.
        }
    }
}
