using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Samsun", "İstanbul");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2= utilities.BuildList<Customer>(new Customer { FirstName = "Beyza" },new Customer {FirstName="Nur"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }

    }
    // Generic sınıflar sıklıkla yaptığımız operasyonları nesne bazlı olarak değştirebileceğimiz bir yapıya işaret eder.< > işaretleri arasına istenilen herhangi bir şey yazılabilir.
    // Genellikle type ı belirtmek için "T" kullanılır.

    //Generic sınıflara kısıt getirilebilir. "T:class => T referans tipi olmalı. T IEntity den implemente edilmeli. Ve new lenebilir olmalı.
    interface IRepository<T> where T : class, IEntity, new() // where T:struct => değer tipi kısıtı koymak için.(int vs )
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entit);
        void Update(T product);

    }
    interface IStudentDal : IRepository<Student>
    {

    }

    interface IEntity
    {

    }
    class Student : IEntity
    {

    }
    interface IProductDal : IRepository<Product>
    {

    }

    interface IcustomerDal : IRepository<Customer>
    {
        void Customer();
    }




    class Customer : IEntity
    {
        public string FirstName { get; set; }
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entit)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer product)
        {
            throw new NotImplementedException();
        }


    }

    class Product : IEntity
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entit)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    class Utilities
    {
        public List<T> BuildList<T>(params T[] items) // Generic metot
        {
            return new List<T>(items);
        } 
    }
}
