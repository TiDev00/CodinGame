using System;

namespace EncodageSimple
{
    class Program
    {
        public static string Encode(string plainText)
        {
            if (plainText != null)
            {
                foreach (var letter in plainText)
                {
                    if (char.IsLetter(letter))
                    {
                        return "good";
                    }
                    else
                    {
                        return "String contains character which is not a letter";
                    }
                }
            }
            else
            {
                return "String is null";
            }
            return "";
        }
        static void Main(string[] args)
        {
            string plainText = Console.ReadLine();
            var stdoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            string encoded = Encode(plainText);
            Console.SetOut(stdoutWriter);
            Console.WriteLine(encoded);
        }
    }
}
