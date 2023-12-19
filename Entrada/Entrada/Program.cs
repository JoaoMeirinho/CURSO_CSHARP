using System;
using System.Globalization;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
           */
            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(lastname);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        
        }
    }
}