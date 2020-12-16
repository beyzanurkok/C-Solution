using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added.");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated.");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added.");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated.");
        }
    }
    class MysqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Updated.");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }

}
