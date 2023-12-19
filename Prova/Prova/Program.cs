using System;

public class Prova
{
    public static void Main()
    {
        int eleitores, votosBrancos, votosNulos, votosValidos;
        double pcBrancos, pcNulos, pcValidos;
        Console.WriteLine("Numero de eleitores: ");
        eleitores = int.Parse(Console.ReadLine());

        Console.WriteLine("Votos brancos: ");
        votosBrancos = int.Parse(Console.ReadLine());

        Console.WriteLine("Votos nulos: ");
        votosNulos = int.Parse(Console.ReadLine());

        Console.WriteLine("Votos Válidos: ");
        votosValidos = int.Parse(Console.ReadLine());

        pcBrancos = votosBrancos * (votosBrancos / 100);
        pcNulos = votosNulos * (votosNulos / 100);
        pcValidos = votosValidos * (votosValidos / 100);

        Console.WriteLine($"Brancos: {pcBrancos}%  Nulos: {pcNulos}%   Válidos: {pcValidos}");



    }
}
