using CompareHash.Entities;

HashSet<Product> a = new HashSet<Product>();
a.Add(new Product("TV", 900.00));
a.Add(new Product("Notebook", 1200.0));

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

//Object: Se equals não for implementado, compara por referÊncia
Product prod = new Product("Notebook", 1200.0);
Console.Write(a.Contains(prod));

//Struct: Compara por valor
Point p = new Point(5, 10);
Console.Write(b.Contains(p));