using ExReadCsv.Entities;
using System;
using System.IO;
using System.Globalization;

string path = @"c:\temp\arq.csv";
string dest = @"c:\temp\out.csv";

string[] src = File.ReadAllLines(path);

using (StreamWriter sw = File.AppendText(dest))

foreach (string line in src)
{
    string[] columns = line.Split(',');
    Product product = new Product(columns[0], float.Parse(columns[1], CultureInfo.InvariantCulture.NumberFormat), int.Parse(columns[2]));
    Console.WriteLine(float.Parse(columns[1], CultureInfo.InvariantCulture));
    sw.WriteLine(product.ToString());
}
