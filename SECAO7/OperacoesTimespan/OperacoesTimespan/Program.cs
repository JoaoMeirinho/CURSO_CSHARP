TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;
TimeSpan t3 = TimeSpan.Zero;

TimeSpan t4 = new TimeSpan(2,3,5,7,11);


Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t4.Days);
Console.WriteLine(t4.Hours);
Console.WriteLine(t4.Minutes);
Console.WriteLine(t4.Seconds);
Console.WriteLine(t4.Milliseconds);
Console.WriteLine(t4.Ticks);

Console.WriteLine(t4.TotalDays);
Console.WriteLine(t4.TotalHours);
Console.WriteLine(t4.TotalMinutes);
Console.WriteLine(t4.TotalSeconds);
Console.WriteLine(t4.TotalMilliseconds);

TimeSpan t5 = new TimeSpan(1, 30, 10);
TimeSpan t6 = new TimeSpan(0, 10, 5);

TimeSpan sum = t5.Add(t6);
TimeSpan dif = t5.Subtract(t6);
TimeSpan mult = t6.Multiply(2.0);
TimeSpan div = t6.Divide(2.0);

Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);

