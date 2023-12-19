DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
Console.ForegroundColor = ConsoleColor.Green;

//Propriedades da data
Console.WriteLine(d);
Console.WriteLine($"1) Date: {d.Date}");
Console.WriteLine($"2) Day: {d.Day}");
Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
Console.WriteLine($"5) Hour: {d.Hour}");
Console.WriteLine($"6) Kind: {d.Kind}");
Console.WriteLine($"7) Millisecond: {d.Millisecond}");
Console.WriteLine($"8) Minute: {d.Minute}");
Console.WriteLine($"9) Month: {d.Month}");
Console.WriteLine($"10) Second: {d.Second}");
Console.WriteLine($"11) Ticks: {d.Ticks}");
Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
Console.WriteLine($"13) Year: {d.Year}");

DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);

//Formatação da Data
Console.WriteLine(d2.ToLongDateString());
Console.WriteLine(d2.ToLongTimeString());
Console.WriteLine(d2.ToShortDateString());
Console.WriteLine(d2.ToShortTimeString());
Console.WriteLine(d2.ToString());
Console.WriteLine(d2);
Console.WriteLine(d2.ToString("yyyy-MM-dd HH:mm:ss.fff"));


DateTime d3 = d2.AddHours(2);
DateTime d4 = d2.AddMinutes(3);

Console.WriteLine(d3);
Console.WriteLine(d4);


//diferença entre datas

DateTime dateStart = new DateTime(2000, 5, 15);
DateTime dateEnd = new DateTime(2000, 5, 18);

Console.WriteLine(dateEnd.Subtract(dateStart));



