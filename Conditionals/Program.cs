// Koşullu İfadeler

Console.Write("Bir sayı giriniz : ");
var num = int.Parse(Console.ReadLine());

/*

if (num == 10)
{
    Console.WriteLine("Number is 10");
}
else
{
    Console.WriteLine("Number is Not 10");
}


 Console.WriteLine(num == 10 ? "Number İs 10" : "Number is Not 10");  // Single Line if else bloğu alternatifi


    if (num == 10)
    {
        Console.WriteLine("Number is 10");
    }
    else if (num == 20)
    {
        Console.WriteLine("Number is 20");
    }
    else
    {
        Console.WriteLine("Number is Not 10 or 20");
    }


switch (num)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is Not 10 or 20");
        break;
}


if (num >= 0 && num <= 100)
{
    Console.WriteLine("Number is between 0 - 100");
}
else if (num > 100 && num <= 200)
{
    Console.WriteLine("Number is between 100 - 200");
}
else if (num > 200 || num < 0)
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}

*/

if (num < 100)  //İç içe nested if blocks örneği

{
    if (num >= 90)
    {
        Console.WriteLine("Number is in 90's");
    }
    else
    {
        Console.WriteLine("Number is not in 90's");
    }

}


Console.ReadKey();