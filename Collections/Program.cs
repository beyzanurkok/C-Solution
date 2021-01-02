using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListCollection();
            //ListCollection();
            //CollectionMethod();
            //DictionaryCollection();

            Console.ReadLine();

        }

        private static void DictionaryCollection()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();//Dictionary ler birer koleksiyondur.ilk parametresi key ve ona karşılık gelen ikinci parametresi valuedir.
            dictionary.Add("book", "kitap");//Koleksiyonun metotları burada da geçerlidir.
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);
           

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("book"));
            Console.WriteLine(dictionary.ContainsValue("tablo"));
        }

        private static void CollectionMethod()
        {
            //İki farklı tanımlama:
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Beyza" });
            //customers.Add(new Customer { Id = 2, FirstName = "Ömer" }); 

            List<Customer> customers = new List<Customer> //
            {

                new Customer { Id = 1, FirstName = "Beyza" },
                new Customer { Id = 2, FirstName = "Ömer" }

            };



            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Beyza"
            };


            customers.Add(customer2);
            customers.AddRange(new Customer[2]   //customers koleksiyonuna yeni bir liste veya koleksiyon eklemek için kullanılan metot.
            {
               new Customer { Id=4,FirstName="Bengisu"},
               new Customer { Id=5,FirstName="Mücahid"}
            });

            Console.WriteLine(customers.Contains(customer2));//verilen parametrenin bulunup bulunmadığını kontrol eden bool bir metottur.
            //customers.Clear();  //listeyi temizler.

            var index = customers.IndexOf(customer2);//parametre olarak verilen değerin baştan index numarasını döndürür.(Birden fazla aynı değer varsa ilk bulduğunu baz alır.)
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer2);
            var index2 = customers.LastIndexOf(customer2);//parametre olarak verilen değerin sondan index numarasını döndürür.(Birden fazla aynı değer varsa ilk bulduğunu baz alır.)
            Console.WriteLine("Index: {0}", index2);

            customers.Insert(0,customer2);//Belirtilen indexe ekleme yapar diğer değerleri silmez, kaydırır.
            customers.Remove(customer2);//Parametre olarak verilen değerin ilk bulduğunu siler.
            customers.RemoveAll(c=>c.FirstName=="Beyza");// First name Beyza olarak atanmış tüm nesneleri siler.

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                
            }
            var count = customers.Count;// 'count' koleksiyonlara ait bir metottur.Listenin eleman sayısını döndürür.
            Console.WriteLine("Count: {0}", count);
            
        }

        private static void ListCollection()
        {
           
           List<string> cities = new List<string>(); // List koleksiyonuyla tek tip koleksiyonlar oluşturulabilir.

            cities.Add("Ankara"); //Sadece string tipinde nesneler eklenebilir.
            cities.Add("Samsun");

            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void ArrayListCollection()
        {
            ArrayList cities = new ArrayList();  // Koleksiyonlar dinamik yapıdadır.ArrayList koleksiyonlarına her tipten nesneler eklenebilir.
            cities.Add("Samsun");               //Eklemek için koleksiyonların kendi içinde bulunan add metotu kullanılır.
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
            Console.WriteLine(cities[2]);
        }

    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }
}
