using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    class DiceSimulator
    {
        private Random _random = new Random();

        public int[] SimulateRolls(int numRolls)
        {
            int[] rollCounts = new int[13]; // Index 0 and 1 will not be used.

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = _random.Next(1, 7);
                int dice2 = _random.Next(1, 7);
                int sum = dice1 + dice2;
                rollCounts[sum]++;
            }

            return rollCounts;
        }
    }
}
