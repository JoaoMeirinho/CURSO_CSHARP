using System;
using System.Globalization;

namespace ExVetor
{
    class Program
    {
        static void Main()
        {
            Aluguel[] vect = new Aluguel[10];
            Console.Write("Quantos Quartos serão reservados?");
            int quantidade = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Reserva #{i + 1}:");
                Console.Write("Nome:");
                string nome = Console.ReadLine();
                Console.Write("Email:");
                string email = Console.ReadLine();
                Console.Write("Quarto:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Aluguel {Inquilino = nome, Email = email};

            }

            Console.WriteLine("Quartos Reservados: ");

            for (int i = 0;i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i].Inquilino}, {vect[i].Email}");
                }
            }
        }
    }
}
