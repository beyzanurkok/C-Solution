using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtuaşMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            Mysql mysql = new Mysql();

            sqlServer.Add();
            mysql.Add();

            Console.ReadLine();



        }
    }

    class Database
    {
        public virtual void Add() // Virtual anahtar kelimesiyle default değerler atanır, sonrasında metotlar override edilebilir ama zorunluluk yoktur.
        {
            Console.WriteLine("Added by default.");

        }
        public virtual void Delete()  // virtual metotların gövdesi olmak zorundadır.
        {
            Console.WriteLine("Deleted by default.");
        }
    }
    class Mysql:Database
    {
        public override void Add() // Add metotu override edilerek özelleştirildi.
        {
            Console.WriteLine("Added by MySql");
            //base.Add();  // default metot çalışır.
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlServer.");
            //base.Add();
        }

    }
}
