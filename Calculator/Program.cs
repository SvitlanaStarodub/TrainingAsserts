using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100000000;
            int y = 10;
            long result = 0;

            result = Calculator.Addition(x, y);
            Console.WriteLine("Addition: ");
            Console.WriteLine("{0} + {1} = {2}", x, y, result);

            result = Calculator.Subtraction(x, y);
            Console.WriteLine("Subtraction: ");
            Console.WriteLine("{0} - {1} = {2}", x, y, result);

            result = Calculator.Multiplication(x, y);
            Console.WriteLine("Multiplication: ");
            Console.WriteLine("{0} * {1} = {2}", x, y, result);

            result = Calculator.Division(x, y);
            Console.WriteLine("Division: ");
            Console.WriteLine("{0} / {1} = {2}", x, y, result);

            Console.ReadKey();
        }
    }
}
