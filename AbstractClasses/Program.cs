using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Mysql();  // Abstract class new'lenemez ancak bu şekilde nesne oluşturalabilir.
            Database database1 = new SqlServer();

            database.Add();
            database.Delete();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database   // abstract classlar en az bir tane abstract metot içermelidir.
    {
        public void Add()
        {
            Console.WriteLine("Added by default");

        }

        public abstract void Delete(); // Abstract metot override edilerek diğer classların içinde kullanılabilir.
                                       // Abstract metotların gövdesi olmamalıdır.
       

    }

    class Mysql : Database   //Abstract metodu miras alan class o metotu override etmelidir.
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Mysql");
        }
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SqlServer");
        }
    }
}
