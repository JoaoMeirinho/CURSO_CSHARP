using ICompar.Entities;

string path = @"c:\temp\in.txt";

try
{
    using StreamReader sr = File.OpenText(path);
    List<Employee> list = new List<Employee>();
    while (!sr.EndOfStream)
    {
        list.Add(new Employee(sr.ReadLine()));
    }
    list.Sort();
    foreach(Employee line in list)
    {
        Console.WriteLine(line);
    }
}catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}