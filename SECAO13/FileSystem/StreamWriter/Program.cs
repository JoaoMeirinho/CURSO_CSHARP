string path = @"c:\temp\file.txt";
string dest = @"c:\temp\dest.txt";
try
{
    string[] lines = File.ReadAllLines(path);

    using (StreamWriter sw = File.AppendText(dest))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.ToString());
}