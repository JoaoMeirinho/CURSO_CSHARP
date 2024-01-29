using ExResolvidoLinq.Entities;
using System.Globalization;
using System.Linq;
using System.IO;

string path = @"c:\temp\in.txt";

List<Products> list = new List<Products>();

using StreamReader sr = File.OpenText(path);
while (!sr.EndOfStream)
{
    string[] line = sr.ReadLine().Split(',');
    string name = line[0];
    double price = double.Parse(line[1], CultureInfo.InvariantCulture);
    list.Add(new Products(name, price));
}

var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Average Price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

var prod = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach(var item in prod)
{
    Console.WriteLine(item);
}


