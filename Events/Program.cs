using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product harDisk = new Product(50);
            harDisk.ProductName = "Hard Disk";
            Product mobilePhone = new Product(50);
            mobilePhone.ProductName = "Mobile Phone";

            //producta event eklendi.
            mobilePhone.StockControlEvent += MobilePhone_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {

                mobilePhone.Sell(10);
                harDisk.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }


        private static void MobilePhone_StockControlEvent()
        {
            Console.WriteLine("Mobile_phone about to finish ");
        }
    }
}
