using ExPolimorfismoProposto.Entities;
using System.Collections.Generic;
using System.Globalization;

List<Product> products = new List<Product>();
Console.Write("Enter the number of products: ");
int numberProducts = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberProducts; i++)
{
    Console.WriteLine($"Product #{i} data:");

    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsFee));
    }
    else if(ch == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct(name, price, manufactureDate));
    }
    else
    {
        products.Add(new Product(name, price));
    }
}

Console.WriteLine("Payments: ");
foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}

