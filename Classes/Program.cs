using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Samsun";
            customer.FirstName = "Beyzanur";
            customer.LastName = "Kök";
            customer.Id = 1;

            Customer customer2 = new Customer { Id = 2, FirstName = "Ömer Faruk", LastName = "Kök", City = "Samsun" };
            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }

    
}
