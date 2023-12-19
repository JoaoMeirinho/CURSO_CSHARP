using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            double deposito, saque;
            ContaBancaria t;

            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            string nome = Console.ReadLine()
            Console.WriteLine("Haverá deposito inicial? (s/n) ");
            char opt = char.Parse(Console.ReadLine());
            

            if (opt == 's')
            {
                Console.WriteLine("Digite o valor para deposito");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                t = new ContaBancaria(numConta, nome, deposito);
            }
            else
            {
                t = new ContaBancaria(numConta, nome);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(t.ToString());

            Console.WriteLine("Entre com um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t.Deposito(deposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(t);

            Console.WriteLine("Entre com um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            t.Saque(saque); 
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(t.ToString());

        }
    }
}