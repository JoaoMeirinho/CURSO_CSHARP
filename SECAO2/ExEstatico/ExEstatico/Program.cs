using System;
using System.Globalization;
namespace ExEstatico
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Quantia em reais a pagar: {ConversorDeMoeda.Converter(cotacao, dolar).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
