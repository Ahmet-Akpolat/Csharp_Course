// Loops (Döngüler)

// Döngüler belirli şartlarda tekrarlı işlemler yapmak için kullabılabilir.


//WhileLoop();
//ForLoop();
//DoWhileLoop();
//ForeachLoop();

if (IsPrimeNumber(7))
{
    Console.WriteLine("Prime Number");
}
else
{
    Console.WriteLine("Not prime number");
}


Console.ReadKey();

return;

void ForLoop()
{
    for (int i = 1;
         i <= 100;
         i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Finished");
} // i, 1'e eşitir. i, 100'den küçük olduğu sürece i'yi 1 arttırarak döngüye devam eder.

void WhileLoop() 
{
    int number = 100;
    while (number  >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
}// while döngüsünde for döngüsündeki gibi şart bloğunda değişken atama, arttırma azaltma gibi şeyler yapamıyoruz.

void DoWhileLoop()
{
    int num = 10;
    do
    {
        Console.WriteLine(num);
        num--;
    } while (num >= 11);
}// do while loop önce çalışmasını istediğimiz komutu çalıştırır sonra şartı kontrol eder.

void ForeachLoop()
{
    string[] students = new string[3] { "Ahmet", "İbrahim", "Serap" };
    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
} // öğrenciler dizisinin elemanlarını ekrana yazdıran döngü

static bool IsPrimeNumber(int number)
{
    bool result = true;

    for (int i = 2; i <= number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            break;
        }
    }

    return result;
} // Sayının asal olup olmadığını bulan döngü