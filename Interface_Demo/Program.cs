// Çoklu İmplementasyon Demo

namespace Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[] // IWorker interfacesinden 3 dizilik eleman oluşturduk.
            {
                new Manager(),
                new Engineer(),
                new Robot()
            };

            foreach (var worker in workers) // Elemanlarımıza çalış emri verdik
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] 
            {
                new Manager(),
                new Engineer(),
            };

            foreach (var eat in eats) // Yiyebilenlere ye emri verdik.
            {
                eat.Eat();
            }

            Console.ReadKey();
        }
    }

    interface IWorker // Çalış
    {
        void Work();
    } 

    interface IEat // Ye
    {
        void Eat();
    } 

    interface ISalary // Maaş al
    {
        void GetSalary();
    }  

    class Manager : IWorker, IEat, ISalary // Manager ve Engineer yer çalışır ve maaş alır ama robot sadece çalışır.
    {
        public void Work()
        {
            Console.WriteLine("Manager is Working");
        }

        public void Eat()
        {
            Console.WriteLine("Manager Eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Got His Salary");
        }
    } 

    class Engineer : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Engineer is Working");
        }

        public void Eat()
        {
            Console.WriteLine("Engineer Eats");
        }

        public void GetSalary()
        {
            Console.WriteLine("Engineer Got His Salary");
        }
    }

    class Robot : IWorker // Manager ve Engineer yer çalışır ve maaş alır ama robot sadece çalışır.
    {
        public void Work()
        {
            Console.WriteLine("Robot is Working");
        }
    }
}