using System;
namespace Mission2Assignments
{ // PROGRAM DOES DICE STUFF
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // establishes array from 2-12
            int[] rollTotals = new int[13];
            // Asks user how many times to roll the dice
            Console.Write("Enter the number of times the dice will be rolled: ");
            int num_rolls = int.Parse(Console.ReadLine());
            // similuate the roll of the die
            for (int i = 0; i < num_rolls; i++)
            {
                int firstDie = r.Next(1, 7);
                int secondDie = r.Next(1, 7);
                int total = firstDie + secondDie;
                rollTotals[total]++;
            }
            Console.WriteLine("\nResults: ");
            // for loop, establish counter, what the counter will go to, and how to increment. Also has the number of asteriks with the roll totals divided by number of rolls
            for (int i = 2; i < 13; i++)
            {
                double numAsterisks = 100 * rollTotals[i] / num_rolls;
                Console.WriteLine($"{i}: " + new string('*', (int)numAsterisks));

                
            }
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}




