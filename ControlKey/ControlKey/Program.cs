using System;

namespace ControlKey
{
    class Program
    {
        public static int ComputeCheckDigit(string identificationNumber)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            string identificationNumber = Console.ReadLine();
            var stdtoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            int checkDigit = ComputeCheckDigit(identificationNumber);
            Console.SetOut(stdtoutWriter);
            Console.WriteLine(checkDigit);
        }
    }
}
