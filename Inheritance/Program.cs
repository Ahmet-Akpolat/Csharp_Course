// Inheritance (Kalıtım)

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{FırstName = "Ahmet",LastName = "Akpolat", City = "İstanbul"},
                new Student{FırstName = "İbrahim",LastName = "Akpolat", Department = "Computer Engineering"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FırstName +" "+ person.LastName);
            }


            Console.ReadKey();
        }

        class Person
        {
            public int Id { get; set; }
            public string FırstName { get; set; }
            public string LastName { get; set; }
        }

        class Person2
        {
        }

        interface IPerson
        {
            
        }

        class Customer : Person , IPerson // Classlara sadece 1 class İnheritance edilebilir ama 1den çok İnterface edilebilir.
        {
            public string City { get; set; }
        }

        class Student : Person, IPerson
        {
            public string Department { get; set; }
        }
    }
}