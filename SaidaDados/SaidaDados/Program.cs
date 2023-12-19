using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.0;
            double medida = 53.0987807;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1.ToString("F2")}");
        }
    }
}