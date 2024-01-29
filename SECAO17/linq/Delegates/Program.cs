using Delegates.Services;


double a = 10;
double b = 12;


BinaryNumericOperation op = CalculationService.Sum;
double result = op.Invoke(a, b);
Console.WriteLine(result);

delegate double BinaryNumericOperation(double n1, double n2);