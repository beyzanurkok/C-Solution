using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer // Bir class'ın default erişim bildirgeci 'internal' dır.
    {
       // private int id { get; set; } // Private sadece bulunduğu blokta erişilebilirdir
        protected int id { get; set; } // Protected' ın private den tek farkı inherit edildiği sınıflarda kullanılabiir olmasıdır.

        private void Save()
        {
            
        }
         private void Delete()
        {

        }
       
    }

    class Student:Customer
    {
        public void Save2()
        {
          
        }
    }
    internal class Course   //İnternal aynı projede her kısımda erişilebilirdir.
    {
        public string Name { get; set; }

    }

    public class Course2 // Public her yerden erişilebilirdir.
    {
        public int Id { get; set; }
    }

}
