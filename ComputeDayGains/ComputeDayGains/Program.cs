using System;

namespace ComputeDayGains
{
    class Program
    {
        public static int ComputeDayGains(int nbSeats, int[] payingGuests, int[] guestMovements)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            string[] inputs;
            int nbSeats = int.Parse(Console.ReadLine());
            int nbGuests = int.Parse(Console.ReadLine());
            int nbMovements = int.Parse(Console.ReadLine());
            int[] payingGuests = new int[nbGuests];
            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < nbGuests; i++)
                {
                payingGuests[i] = int.Parse(inputs[i]);
                }
            int[] guestMovements = new int[nbMovements];
            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < nbMovements; i++)
                {
                guestMovements[i] = int.Parse(inputs[i]);
                }
            var stdtoutWriter = Console.Out;
            Console.SetOut(Console.Error);
            int res = ComputeDayGains(nbSeats, payingGuests, guestMovements);
            Console.SetOut(stdtoutWriter);
            Console.WriteLine(res);
        }
    }
}
