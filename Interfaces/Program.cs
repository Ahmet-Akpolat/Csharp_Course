// İnterfaces (Arayüzler)

// bir sınıfın veya bir yapısal türün belirli bir davranışı uygulama veya sözleşmelere uyma yeteneği kazanmasına yardımcı olan bir yapıdır.

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        { 
            InterfacesIntro();

            // CustomerDemo();

            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadKey();
        }

        private static void CustomerDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            ProductManager manager = new ProductManager();
            manager.Add(new Phone
            {
                Id = 1,
                Model = "15 Pro",
                Name = "Iphone",
                Color = "Space Black"
            });

            Computer computer = new Computer
            {
                Id = 2,
                Model = "16.2",
                Name = "Victus",
                GraphicCard = "3050 Tİ 6GB"
            };

            manager.Add(computer);
        }
    }

    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Model { get; set; }
    }

    public class Phone : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }

    public class Computer : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string GraphicCard { get; set; }
    }

    public class ProductManager
    {
        public void Add(IProduct product)
        {
            Console.WriteLine(product.Name + " " + product.Model);
        }
    }
}