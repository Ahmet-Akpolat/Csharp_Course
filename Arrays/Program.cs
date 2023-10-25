// Diziler (Arrays)

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Ahmet";
            string student2 = "İbrahim";
            string student3 = "Serap";
            string[] students = new string[5]; // 5 elemanlı string dizisi. (Daha fazla tanımlanamaz).
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            students[3] = "Büşra";
            students[4] = "Taha";

            string[] students2 = {"Ahmet","İbrahim","Serap"}; // String dizileri daha basit olarak böyle de tanımlanabilir.
            

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("------------------------------------");

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3] // 7 satır ve 3 sütun alan karmaşık dizi.
            {
                { "İstanbul", "Edirne", "Tekirdağ" },
                { "Ankara", "Eskişehir", "Konya" },
                { "Antalya", "Mersin", "Adana" },
                { "Trabzon", "Rize", "Samsun" },
                { "İzmir", "Muğla", "Aydın" },
                { "Iğdır", "Kars", "Erzurum" },
                { "Şanlıurfa", "Diyarbakır", "Gaziantep" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("------");
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
            }

            Console.ReadKey();
        }
    }
}