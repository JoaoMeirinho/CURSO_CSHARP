using System.Linq;
using System.Globalization;
using ExPropostoLinq.Entities;

var path = @"c:\temp\in.txt";

List<Employee> employees = new List<Employee>();

using StreamReader sr = File.OpenText(path);
while (!sr.EndOfStream)
{
    string[] line = sr.ReadLine().Split(',');
    string name = line[0];
    string email = line[1];
    double price = double.Parse(line[2], CultureInfo.InvariantCulture);
    employees.Add(new Employee(name, email, price));
}

Console.Write("Enter the value of Salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

var EmailSalaryUpTo = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);
Console.WriteLine("Email of employees with salary up to " + salary + ":");
foreach(var email in EmailSalaryUpTo)
{
    Console.WriteLine(email);
}
Console.WriteLine();

var sumSalaryEmployeeWithFirstCharM =
    (from emp in employees
     where emp.Name[0] == 'M'
     select emp).Sum(p => p.Salary);

Console.WriteLine("Sum of salary of employees with first char M: " + sumSalaryEmployeeWithFirstCharM.ToString("F2", CultureInfo.InvariantCulture));

