using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // Delegate ler metotları tutabilen yapılardır.Geri dönüş tipi eklenecek metotla aynı olmalıdır.
    public delegate void DelegateMessenger();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    
    class Program
    {
        static void Main(string[] args)
        {
            //DelegateExamples();

            ActionExamples();

            Console.ReadLine();
        }

        private static void ActionExamples()
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();

            Action action = customerManager.ShowAlert;

            matematik.Calculater(customerManager.SendMessage);

            matematik.Calculater(action);
        }

        private static void DelegateExamples()
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            DelegateMessenger delegateMessenger = customerManager.SendMessage; // customerManager nesnesindeki sendMessage Metodu delegateMessenger Delegate ine eklendi.
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            MyDelegate3 myDelegate3 = matematik.Topla;

            delegateMessenger += customerManager.ShowAlert; //customerManager nesnesindeki sendMessage Metodu ShowAlert Delegate ine eklendi.
            delegateMessenger -= customerManager.SendMessage;

            myDelegate2 += customerManager.ShowAlert2;

            myDelegate3 += matematik.Carp;

            delegateMessenger(); // delegateMessenger a atanan metotlar çağırıldı.
            var sonuc = myDelegate3(2, 3); // değer döndüren  delegatedeki birden fazla metotlarda en son hesaplanan(delegate e ekleme sırasına göre) değer görüntülenir.
            Console.WriteLine(sonuc);
            myDelegate2("Hello");
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Carefull!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1 , int sayi2)
        {
            return sayi1 * sayi2;
        }

        public void Calculater(Action action)
        {
            Random random = new Random();

            if (random.Next(1,100) < 10)
            {
                action.Invoke();
            }
        }
    }


}
