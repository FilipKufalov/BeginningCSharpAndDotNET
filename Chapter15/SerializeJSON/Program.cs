
using SerializeJSON;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


//List<Book> books = new List<Book>();

//Book book1 = new Book
//{
//    title = "Beginning C# and .NET",
//    author = "Benjamin Perkins and Jon Reid",
//    code = "978-1119795780"
//};
//Book book2 = new Book
//{
//    title = "Beginning XML",
//    author = "Joe Fawcett et al",
//    code = "978-1118162132"
//};
//Book book3 = new Book
//{
//    title = "Professional C# 7 and .NET Core",
//    author = "Christian Nagel",
//    code = "978-1119449270"
//};
//books.Add(book1);
//books.Add(book2);
//books.Add(book3);
//string jsonString1 = JsonSerializer.Serialize(books, typeof(List<Book>));
//File.WriteAllText("../../../Books.json", jsonString1);

//string jsonString2 = File.ReadAllText("Books.json");
//List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);
//foreach (Book b in books2)
//{
//    Console.WriteLine("code: {0} title: {1} author: {2}", b.code, b.title, b.author);
//}

string jsonString3 = File.ReadAllText("../../../Weather.json");
List<Weather> weathers = JsonSerializer.Deserialize<List<Weather>>(jsonString3);
foreach (Weather item in weathers)
{
    Console.WriteLine("{");
    Console.WriteLine("\t" + nameof(item.Date) + ": " + item.Date.ToString());
    Console.WriteLine("\t" + nameof(item.TemperatureCelsius) + ": " + item.TemperatureCelsius.ToString());
    Console.WriteLine("\t" + nameof(item.Summary) + ": " + item.Summary.ToString());
    Console.Write("\t" + nameof(item.DatesAvailable) + ": ");
    foreach (DateTime datAvail in item.DatesAvailable)
    {
        if (item.DatesAvailable.Last() == datAvail)
            Console.Write(datAvail.ToString());
        else
            Console.Write(datAvail.ToString() + ", ");
    }
    Console.WriteLine();
    Console.WriteLine("\t" + nameof(item.TemperatureRanges) + ": ");
    Console.WriteLine("\t{");
    Console.WriteLine("\t\t" + nameof(item.TemperatureRanges.Cold) + ": ");
    Console.WriteLine("\t\t{");
    Console.WriteLine("\t\t\t" + nameof(item.TemperatureRanges.Cold.High) + ": " + item.TemperatureRanges.Cold.High);
    Console.WriteLine("\t\t\t" + nameof(item.TemperatureRanges.Cold.Low) + ": " + item.TemperatureRanges.Cold.Low);
    Console.WriteLine("\t\t}");
    Console.WriteLine("\t\t" + nameof(item.TemperatureRanges.Hot) + ": ");
    Console.WriteLine("\t\t{");
    Console.WriteLine("\t\t\t" + nameof(item.TemperatureRanges.Hot.High) + ": " + item.TemperatureRanges.Hot.High);
    Console.WriteLine("\t\t\t" + nameof(item.TemperatureRanges.Hot.Low) + ": " + item.TemperatureRanges.Hot.Low);
    Console.WriteLine("\t\t}");
    Console.WriteLine("\t}");
    Console.Write("\t" + nameof(item.SummaryWords) + ": ");
    foreach (string word in item.SummaryWords)
    {
        if (item.SummaryWords.Last() == word)
            Console.Write(word);
        else
            Console.Write(word + ", ");
    }
    Console.WriteLine();
    Console.WriteLine("}");
    Console.ReadKey();
}

