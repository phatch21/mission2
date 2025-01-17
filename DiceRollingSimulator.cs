using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Payton Hatch
// Group 4-6

// namespace of the project name for reference
namespace mission2

{   // second class
    internal class DiceSimulator
    {   
        // random object created
        private Random _random = new Random();

        //method to calculate each roll
        public int[] SimulateRolls(int numRolls)
        {
            // creates an array in which index 0 and 1 will not be used for simplicity
            int[] rollCounts = new int[13]; 

            // for loop that iterates through the number of rolls passed to the method
            for (int i = 0; i < numRolls; i++)
            {
                // random number for each die between 1 and 6 since Next() is not inclusive
                int dice1 = _random.Next(1, 7); 
                int dice2 = _random.Next(1, 7);
                int sum = dice1 + dice2;
                rollCounts[sum]++;
            }

            // returns the calculated array
            return rollCounts;
        }
    }
}
