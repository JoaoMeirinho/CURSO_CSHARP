using MulticastDelegates.Services;


double a = 10;
double b = 12;


BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;
op.Invoke(a, b);

delegate void BinaryNumericOperation(double n1, double n2);
