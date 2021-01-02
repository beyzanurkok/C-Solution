using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Artık CustomerManager ve Product Classları parametreli ya da parametresiz olarak kullanılabilir.
            CustomerManager customerManager = new CustomerManager(10);
            CustomerManager customerManager2 = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "beyza" };
            Product product1 = new Product();
            Product product2 = new Product(2,"Computer"); 

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());// Bu kullanım sayesinde istenilen logger tek satırda oluşturulabiliyor.
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
           





            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count; // private bir field isimlendirme standartları gereğince' _ ' ile başlatılır.
        public CustomerManager(int count)//Product classının 1 parametreli constructorı.
        {
            _count = count;
        }

        public CustomerManager()//CustomerManager classının parametresiz constructorı. 
                                // Constructorslar parametreleri overloading etmek için kullanılır ve class ile aynı isimde olurlar.
        {                          

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);

        }

        public void Add()
        {
            Console.WriteLine("Added.");
        }
    }
    class Product
    {
        public Product() // Product classının parametresiz constructorı.
        {

        }

        private int _id;
        private string _name;

        public Product(int id,string name) //Product classının 2 parametreli constructorı.
        {
            _id = id;
            _name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database.");
        }
    }

    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File.");
        }
    }

    class EmployeeManager
    {

        private ILogger _logger;
        public EmployeeManager(ILogger logger)//constructors enjeksiyonu yapıldı.
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added.");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity) //miras alınan classta parametreli constructor bulunduğu için bu şekilde ata classın constructoruna parametre yollanabilir.
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();//miras alınan metod çağırıldı.
            
        }
    }
}
