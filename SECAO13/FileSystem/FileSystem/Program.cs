using System;
using System.IO;

string srcPath = @"c:\temp\file.txt";
string destPath = @"c:\temp\dest.txt";

try
{
    //FileInfo fileInfo = new FileInfo(srcPath);
    //fileInfo.CopyTo(destPath);
    string[] lines = File.ReadAllLines(srcPath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}catch (IOException e)
{
    Console.WriteLine("Ocorreu um ERRO: ");
    Console.WriteLine(e.Message);
}
