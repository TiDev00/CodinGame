using System;

namespace QuadraticFunction
{
    class Program
    {
        public static int ApplyFunction(string quadraticFunction, int x)
        {
            return 0;
        }
        
        static void Main(string[] args)
        {
            string quadraticFunction = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            var stdtoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            int result = ApplyFunction(quadraticFunction, x);
            Console.SetOut(stdtoutWriter);
            Console.WriteLine(result);
        }
    }
}
