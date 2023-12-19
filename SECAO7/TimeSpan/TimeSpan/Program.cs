﻿TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(4, 12, 20);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);

TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);
TimeSpan t8 = TimeSpan.FromMinutes(1.5);

Console.WriteLine(t6);
Console.WriteLine(t7);
