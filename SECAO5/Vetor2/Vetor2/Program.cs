using System;
using System.Globalization;

namespace Vetor2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vet[i] = new Product { Name = name, Price = price }; 
            }

            double sum = 0;

            for (int i = 0;i < n; i++)
            {
                sum += vet[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}