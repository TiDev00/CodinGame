using System;

namespace RebuildMessage
{
    class Program
    {
        public static string RebuildMessage(string[] parts)
        {
            return "";
        }
        
        static void Main(string[] args)
        {
            string[] inputs;
            int partsCount = int.Parse(Console.ReadLine());
            string[] parts = new string[partsCount];
            for (int i = 0; i < partsCount; i++)
            {
                parts[i] = Console.ReadLine();
            }
            var stdtoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            string message = RebuildMessage(parts);
            Console.SetOut(stdtoutWriter);
            Console.WriteLine(message);
        }
    }
}
