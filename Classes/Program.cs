// Classes (Sınıflar)

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Remove();

            Console.WriteLine("===================");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Ahmet";
            customer.LastName = "Akpolat";

            Customer customer2 = new Customer()
            {
                Id = 2, City = "İstanbul", FirstName = "İbrahim", LastName = "Akpolat"
            };

            Console.WriteLine("==================");
            Console.WriteLine("1. Müşteri: " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine("2. Müşteri: " + customer2.FirstName + " " + customer2.LastName);

            Console.ReadKey();
        }
    }
}



