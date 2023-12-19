using System.Globalization;

DateTime d1 = DateTime.Now;
Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);

DateTime d2 = new DateTime(2222, 11, 25);
DateTime d3 = new DateTime(2022, 11, 23, 20, 45, 20);
DateTime d4 = new DateTime(2022, 11, 23, 20, 45, 20, 500);

DateTime d5 = DateTime.Now;
DateTime d6 = DateTime.Today;
DateTime d7 = DateTime.UtcNow;

Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);

Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);

DateTime d8 = DateTime.Parse("2000-08-15");
DateTime d9 = DateTime.Parse("2000-08-15 13:05:08");

DateTime d10 = DateTime.Parse("15/08/2000");

DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("2000@08@15", "yyyy@MM@dd", CultureInfo.InvariantCulture);

Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);