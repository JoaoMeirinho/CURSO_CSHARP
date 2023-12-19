using System;
using System.IO;
using System.Collections.Generic;

string path = @"c:\temp";
try
{
    IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Folders:");
    foreach (string folderName in folder)
    {
        Console.WriteLine(folderName);
    }

    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("Files:");
    foreach (string fileName in files)
    {
        Console.WriteLine(fileName);
    }

    Directory.CreateDirectory(path + @"\newFolder");
}
catch(IOException e)
{
    Console.WriteLine("Ocorreu um erro");
    Console.WriteLine(e.Message);
}
