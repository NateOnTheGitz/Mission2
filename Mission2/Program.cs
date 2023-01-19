using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numRolls = 100;
            int[] rollTotals = new int[12];

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            //numRolls = Console.ReadLine();

            for (int i = 0; i < numRolls; i++)
            {
                int roll = r.Next(6);
                rollTotals[roll] = rollTotals[roll] + 1;
            }

            Console.WriteLine(rollTotals[4]);
        }
    }
}
