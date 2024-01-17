string path = @"c:\temp\in.txt";
Dictionary<string, int> people = new Dictionary<string, int>();

try
{
    using StreamReader sr = new StreamReader(path);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        string[] name = line.Split(',');
        if (people.ContainsKey(name[0]))
        {
            people[name[0]] += int.Parse(name[1]);
        }
        else
        {
            people.Add(name[0], int.Parse(name[1]));
        }
    }
}catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

foreach(KeyValuePair<string, int> entry in people)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}

