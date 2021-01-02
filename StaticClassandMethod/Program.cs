using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassandMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher.Number = 10; //Static nesnelerin bir instance ı oluşturulamaz.(newlenemez)
                                 //Arka planda tek bir nesne oluşturuluyor ve tüm kullanıcılar tek bir nesne tüketiliyor.
                                 //Static nesneler herkes tarafından ortak kullanıldığı için biri için değitiğinde herkes için değişiyor.
            Utilities.Validate();
            Manager.DoSomething();//static classlarda çağırma işlemi direk olarak sınıf isminden yapılır.
            Manager manager = new Manager();//static olmayan ise instance üzerinden çağırılıyor.
            manager.DoSomething2();
        }
    }

    static class Teacher // Static Classların tüm nesne ve metotları da static olmalıdır.
    {
        public static int Number { get; set; }
    }

    static class Utilities

    {
         static Utilities()//Static bir nesnede mutlaka kullanılması istenen kod bloğu için constructor kullanılabilir.
        {

        }
        public static void Validate()
        {
            Console.WriteLine("Validation is done.");
        }
    }

    class Manager
    {
        static public void DoSomething()
        {
            Console.WriteLine("Done");
        }
         public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }

    }

}
