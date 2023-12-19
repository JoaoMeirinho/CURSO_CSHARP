using System;
using System.Collections.Generic;

List<string> list = new List<string>();

//add: adiciona elemento ao final da lista
list.Add("Maria");
list.Add("Bob");
list.Add("Ana");
list.Add("Jonas");
list.Add("Camilla");
list.Add("João");

//insert: adiciona elemento no index informado
list.Insert(2, "Marco");




foreach(string item in list)
{
    Console.WriteLine(item);
}

//count: retorna o tamanho da lista
Console.WriteLine("número de elementos: " + list.Count);

//find: Primeira ocorrência com a expressão desejada
string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("Primeiro com a letra A: " + s1);

//findLast: última ocorrência com a expressão desejada
string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Ultimo com a letra A: " + s2);

//findIndex: Index da primeira ocorrência
int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("posição primeira ocorrência com A: " + pos1);

//findIndex: Index da primeira ocorrência
int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("posição última ocorrência com A: " + pos1);

List<string> filtredList = list.FindAll(x => x.Length == 5);

foreach (string item in filtredList)
{
    Console.WriteLine(item);
}

list.Remove("Alex");

Console.WriteLine("----------------------");
foreach(string item in list)
{
    Console.WriteLine(item);
}

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("----------------------");
foreach (string item in list)
{
    Console.WriteLine(item);
}

list.RemoveAt(1);
Console.WriteLine("----------------------");
foreach (string item in list)
{
    Console.WriteLine(item);
}

//removeRange: (posição inicial | Quantos elementos serão removidos a partir da posição inicial)
list.RemoveRange(1,2);
Console.WriteLine("----------------------");
foreach (string item in list)
{
    Console.WriteLine(item);
}

