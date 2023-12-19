double? x = null;
double? y = 10.0;
double z = x ?? 0.0;

Console.WriteLine(x.GetValueOrDefault());
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);

if (x.HasValue) Console.WriteLine(x.Value);
else Console.WriteLine("X is null");

if (y.HasValue) Console.WriteLine(y.Value);
else Console.WriteLine("Y is null");

Console.WriteLine(z);