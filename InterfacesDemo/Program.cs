using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWork[] Workers = new IWork[3]
            {
            new Worker(),
            new Manager(),
            new Robot()
            };

            foreach (var worker in Workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2] { new Worker(), new Manager() };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


        }

        interface IWork
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void GetSalary();
        }

        class Worker : IWork, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker Eating.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Worker getting salary.");
            }

            public void Work()
            {
                Console.WriteLine("Worker working.");
            }
        }
        class Manager:IWork,ISalary,IEat
        {
            public void Eat()
            {
                Console.WriteLine("Manager Eating.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager getting salary.");
            }

            public void Work()
            {
                Console.WriteLine("Manager working.");
            }
        }
        class Robot : IWork
        {
            public void Work()
            {
                Console.WriteLine("Robot working.");
            }
        }

    }
}
