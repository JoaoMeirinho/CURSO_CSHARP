using Action.Entities;

List<Product> list = new();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

Action<Product> act = UpdatePrice;

list.ForEach(act);
foreach(Product product in list)
{
    Console.WriteLine(product);
}


static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1;
}

