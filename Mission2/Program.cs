using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up a random number generator
            Random r = new Random();
            //Variables to hold the number of rolls and how many times each number has been rolled
            int numRolls = 0;
            int[] rollTotals = new int[12];

            //Get information from the user
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? ");
            //Validate to be sure it's a numerical input
            while (!Int32.TryParse(Console.ReadLine(), out numRolls))
            {
                Console.WriteLine("Wrong input! Please enter a number of rolls:");
            }

            //Loop as many times as the user directs
            for (int i = 0; i < numRolls; i++)
            {
                //Roll both "dice" and add them together
                int roll = r.Next(6);
                roll += r.Next(6);
                //Add one to the total of whatever number was rolled
                rollTotals[roll] = rollTotals[roll] + 1;
            }

            //Print out some explanatory text
            Console.WriteLine('\n' + "DICE ROLLING SIMULATOR RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine($"Total number of rolls = {numRolls}" + '\n');

            //Print out the results by looping through the array
            for (int i = 0; i < 11; i++)
            {
                //Divide the roll count for a given number by the total number of rolls to get the %
                double rollDouble = Convert.ToDouble(numRolls);
                int starCount = 0;
                starCount = (int)(rollTotals[i] / rollDouble * 100);
                //string myString = $"Starcount = {starCount}";
                //Console.WriteLine(myString);
                string stars = "";
                string printLine = "";
                //Add a star for each %
                for (int j = 0; j < starCount; j++)
                {
                    stars = stars + "*";
                }
                //Print out the results
                printLine = string.Format("{0}: {1}", i + 2, stars);
                Console.WriteLine(printLine);
            }
            Console.WriteLine('\n' + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
