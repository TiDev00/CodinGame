using System;

namespace ComputeMultipleSum
{
    class Program
    {
        public static int ComputeMultipleSum(int n)
        {
            return 0;
        }
        
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            var stdtoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            int res = ComputeMultipleSum(n);
            Console.SetOut(stdtoutWriter);
            Console.WriteLine(res);
        }
    }
}
