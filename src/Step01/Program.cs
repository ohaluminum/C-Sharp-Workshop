using System;

namespace Step01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCalculatorTest();
        }

        static void RunCalculatorTest()
        {
            Console.WriteLine("Calculator testing starts: ");
            Console.WriteLine(Calculator.add(5, 2));
            Console.WriteLine(Calculator.sub(5, 2));
            Console.WriteLine(Calculator.mul(5, 2));
            Console.WriteLine(Calculator.div(5, 2));
            Console.WriteLine(Calculator.div(5, 0));
        }
    }

    class Calculator
    {
        internal static int add(int x, int y) => x + y;
        internal static int sub(int x, int y) => x - y;
        internal static int mul(int x, int y) => x * y;
        internal static int div(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException();
            return x / y; 
        }
    }
}
