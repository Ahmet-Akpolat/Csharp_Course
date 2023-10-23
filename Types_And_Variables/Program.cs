// Veri Tipleri Ve Değişkenler

/* Console.WriteLine("Hello World");
   Console.ReadLine(); */

double num5 = 0.8; // ondalıklı sayı alabilir. 
char character = 'A'; //char ascii tablosundan tek 1 değer alır.
string city = "Ankara"; //string karakter dizisidir.

decimal longNum5 = 0.233M;
bool function = true;
byte num4 = 255;
short num3 = 32767;
int num1 = 2147483647;
long num2 = 9223372036854775807;
var num7 = 10;
num7 = 'Z';

// {} index ifade eder. İndex 0dan başlar.
Console.WriteLine(num1);
Console.WriteLine("Num 1 is {0}",num1);
Console.WriteLine("Num 2 is {0}",num2);
Console.WriteLine("Num 3 is {0}",num3);

// İndexi {1} olan sayı 2. sayı olan num4 dür.
Console.WriteLine("Num 4 is {1}",num3,num4);
Console.WriteLine("Num 5 is {0}", num5);
Console.WriteLine("Num 7 is {0}", num7);
Console.WriteLine("Character : {0}", (int)character);
Console.WriteLine("Friday's index : " + (int)Days.Friday);

enum Days
{
    Monday = 5, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}