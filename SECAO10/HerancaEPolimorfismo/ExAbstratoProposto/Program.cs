using ExAbstratoProposto.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
List<TaxPayer> taxPayer = new List<TaxPayer>();
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.WriteLine("Individual or Company (i/c)?");
    char option = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(option == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthexpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        taxPayer.Add(new IndividualTaxPayer(name, anualIncome, healthexpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());

        taxPayer.Add(new CompanyTaxPayer(name, anualIncome, employees));
    }
}

Console.WriteLine("TAXES PAID");
double sum = 0;
foreach (TaxPayer payer in taxPayer)
{
    Console.WriteLine($"{payer.Name}: ${payer.Taxes().ToString("F2", CultureInfo.InvariantCulture)}");
    sum += payer.Taxes();
}

Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");