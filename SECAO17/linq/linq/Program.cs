using Comparison.Entities;

List<Product> list = new();

list.Add(new Product("TV", 900.00));
list.Add(new Product("Notebook", 1200.00));
list.Add(new Product("Tablet", 450.00));

Comparison<Product> comparison = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach(Product p in list)
{
    Console.WriteLine(p);
}




