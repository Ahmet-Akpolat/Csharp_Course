// Metotlar

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //Add2(1, 5);
            //var sum = Add2(50);

            //int num1 = 20;
            //int num2 = 100;
            //var sum2 = Add3(out num1, num2);
            //Console .WriteLine(sum2);
            //Console.WriteLine(num1);

            Console.WriteLine(Multiply(5, 7));
            Console.WriteLine(Multiply(5, 8, 3));
            Console.WriteLine(Add4(1,2,3,4,5,6,7,8,9));

            Console.ReadKey();
        }


        static void Add()
        {
            Console.WriteLine("Added!!!!");
        } // çağırıldığında konsola added!!! yazdıran bir metot örneği.

        static int Add2(int num1, int num2 = 50) // num2 default değeri 50dir. Metot çağırıldığında num2 tanımlanmazsa 50 olarak alınır.
        {
            int sum = num1 + num2;
            return sum;
        } // çağırıldığında verilen 2 integer değeri toplayıp geri döndüren bir metot örneği.

        static int Add3(out int num1, int num2)
        {
            num1 = 30;
            return num1 + num2;
        } // ref keywordu değer tiplerinin referans tip olarak kullanmayı sağlar. Metotun içinde değişen değerin metodun dışında da değişemsini sağlar.
        //out keywordu de aynı şeyi yapar ama out keywordunde metotun dışındaki parametreye değer atamanız gerekmez. Ref'de gerekir.

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Multiply(int num1, int num2, int num3) // Method overload örneği
        {
            return num1 * num2 * num3;
        }

        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}