using System;


namespace ExLista
{
    class Program
    {
        static void Main()
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.WriteLine("How many employees will be registred?");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Employee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Funcionario { Id = id, Name = name, Salary = salary });
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            int index = list.FindIndex(id => id.Id == idIncrease );
            list[index].AddPercentage(percentage);

            foreach (Funcionario funcionario in list)
            {
                Console.WriteLine($"{funcionario.Id}, {funcionario.Name}, {funcionario.Salary}");
            }
            
            
        }
    }
}