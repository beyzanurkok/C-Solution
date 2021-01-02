using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2_Soyutlama_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger(); // Loglamak istenilen alan için nesne oluşturuldu.
            customerManager.Add();
            Console.ReadLine();

        }

    }

    class CustomerManager
    {

        public ILogger Logger { get; set; } // Her yeni loglama için kodu değiştirmemek adına Ilogger prop oluşturuldu.
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }

    }


    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File!");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to SMS!");
        }
    }

    interface ILogger
    {
        void Log();
    }
}
