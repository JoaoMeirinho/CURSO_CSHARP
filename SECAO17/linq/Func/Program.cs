using Func.Entities;
using System.Linq;
List<Product> list = new();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

List<string> result = list.Select(NameUpper).ToList();
foreach (string s in result)
{
    Console.WriteLine(s);
}

static string NameUpper(Product p)
{
    return p.Name.ToUpper();
}

