using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleServerCustomerDal(),new MysqlServerCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();

        }

        private static void Demo()
        {
           
            CustomerManager customerManager = new CustomerManager();
            OracleServerCustomerDal oracleServerCustomerDal = new OracleServerCustomerDal();
            customerManager.Add(oracleServerCustomerDal);
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Student { Id = 1, FirstName = "Beyza", LastName = "Kök", Addresses = "Bilgisayar" });
            Console.ReadLine();
        }

        interface IPerson
        {
             int Id { get; set; }
             string FirstName { get; set; }
             string LastName { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Addresses { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
