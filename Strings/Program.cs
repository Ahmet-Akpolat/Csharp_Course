// Stringler ve String Metotları 

//StringMethod1();
string sentence = "My name is Ahmet Akpolat";

var result  = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Büşra Akpolat";

bool result3 = sentence.EndsWith("t");
bool restul4 = sentence.StartsWith("My name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Sentence : ");
var result9 = sentence.Substring(11);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace("name", "nick");
var result13 = sentence.Remove(2,8);



Console.WriteLine(result13);


Console.ReadKey();
return;

void StringMethod1()
{
    string city = "İstanbul";

// Console.WriteLine(city[0]);

    foreach (var c in city)
    {
        Console.WriteLine(c);
    }

    string city2 = "Iğdır";
// string result = city +" "+  city2;

    Console.WriteLine(string.Format("{0} {1}", city, city2)); // 3. bir değişken oluşturmadan stringleri birleştirmek.
}