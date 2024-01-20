using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eurojackpot
{
    internal class NumberSelection
    {
        private static int[] FiveNumbers = new int[5];
        private static int[] TwoNumbers = new int[2];
        private static int newNumber = 0;
        private static Random randomNumberGenerator = new Random();
        private static void SelectFive() // First you select 5 numbers from 1 to 50.
        {
            for (int i = 0; i < 5; i++)
            {
                newNumber = randomNumberGenerator.Next(1, 51);
                while (FiveNumbers.Contains(newNumber)) // To avoid duplicates.
                {
                    newNumber = randomNumberGenerator.Next(1, 51);
                }
                FiveNumbers[i] = newNumber;
                newNumber = 0;
            }
            Array.Sort(FiveNumbers); // Sort in ascending order.
        }
        private static void SelectTwo() // Then you select 2 numbers from 1 to 12.
        {
            for (int i = 0; i < 2; i++)
            {
                newNumber = randomNumberGenerator.Next(1, 13);
                while (TwoNumbers.Contains(newNumber)) // To avoid duplicates.
                {
                    newNumber = randomNumberGenerator.Next(13);
                }
                TwoNumbers[i] = newNumber;
                newNumber = 0;
            }
            Array.Sort(TwoNumbers); // Sort in ascending order.
        }
        public static void SelectNumbers(int numberOfBoards) // One method to select all 7 numbers and write them in the console.
        {
            for (int i = 1; i <= numberOfBoards; i++)
            {
                SelectFive();
                SelectTwo();
                Console.WriteLine($"Board {i}: {String.Join(", ", FiveNumbers)} || {String.Join(", ", TwoNumbers)}");
            }
            Console.WriteLine();
            Console.WriteLine("Good luck!");
            Console.ReadLine();
        }
    }
}
