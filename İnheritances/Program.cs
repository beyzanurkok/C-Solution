using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]  // Person ataclassı tipinde bir dizi oluşturuldu, içine kalıtım alan classlardan nesneler oluşturuldu.
            {
                new Customer{LastName="Aydın"},
                new Student{LastName="Kök"},
                new Person{LastName="Özmen"}

            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.LastName);

            }
            Console.ReadLine();

        }
    }
    class Person    //Person class ı ata classdır.Interface in aksine Person Class ının tek başına da bir anlamı vardır.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }

    class Student : Person   /* Student class ı Person classından miras almıştır
                                ve Person classına ait özellik ve metotları tekrar tanımlamasına gerek kalmadan kullanabilir.*/
    {
        public string Department { get; set; }

    }
    class Customer : Person  /* Kalıtım almak için ' : ' sonrasında miras alınacak class ın adı yazılır,Birden fazla kalıtım mümkün değildir
                           ancak kalıtım ve interface aynı anda kullanılabilir.Başta miras alınan class sonrasın da istenilen interfaceler
                           aralarında ' , ' kullanılarak yazılabilir */
    {
        public string City { get; set; }
    }
}
