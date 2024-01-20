using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurojackpot
{
    internal class UserInput
    {
        public static int NumberOfBoards = 0;
        public static void SelectNumberOfBoards()
        {
            while (NumberOfBoards == 0)
            {
                Console.WriteLine("How many boards do you want to select?");
                Console.WriteLine("Write a number from 1 to 6.");
                if (int.TryParse(Console.ReadLine(), out int numberOfBoards))
                {
                    if (numberOfBoards > 0 && numberOfBoards < 7) // if the user writes a number from 1 to 6, the number of boards is assigned this value
                    {
                        NumberOfBoards = numberOfBoards;
                    }
                    else if (numberOfBoards > 6) // if the user writes a number bigger than 6, the number of boards is 6, the maximum possible
                    {
                        NumberOfBoards = 6;
                    }
                }
                Console.Clear(); // if the user writes anything other than an integer, the instructions just reload
            }
        }
    }
}
