using System;

namespace Params
{
    class Program
    {
        static void Main()
        {
            int s1 = Calculator.Sum(1,2,3,4,5);
            int a = 10;
            int triple;


            Console.WriteLine(s1);
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
        }
        
    }
}
