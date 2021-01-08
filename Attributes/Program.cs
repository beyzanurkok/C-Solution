using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "kök", Age = 23 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
    }
    //Attributelar ile çalışma anında classlara ,nesnelere ,nesnelerin özelliklerine veya metotlarına anlam katabiliriz.Attributelara parametre eklenebilir.
    [ToTable("Customers")]
    [ToTable("tblCustomers")] //Her iki tabloda da ara anlamında iki kez toTable attiribute u kullanılabilir.
    class Customer
    {
      
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Dont use add, instead use AddNew method!")] // Obsolate hazır nir attribute dur.Eski kullanım manasında.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }
    // Attributelere attribute uygulanabilir.Burada RequiredPropertyAttribute unun sadece propertyler de kullanabileceğini belirtir.Fazladan eklemek için " | "  ile devam edilebilir.
    [AttributeUsage(AttributeTargets.Property)] 
    class RequiredPropertyAttribute:Attribute
    {

    }
    //AllowMultiple , aynı attribute u birden fazla kez kullanmaya izin verir.
    [AttributeUsage(AttributeTargets.Class , AllowMultiple =true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
}
