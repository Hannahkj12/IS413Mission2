using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hannah Johnson IS 4013 Section 2
//This program simulates rolling two dice & shows the frequency of the totals based on the number of times that the user chooses to roll them.

namespace IS413Mission2
{
    class DiceRolls
    {
        public int[] SimulateDiceRolls(int iNumRolls)
        {
            //create new instance of the Random class
            Random random = new Random();
            //create an array with with spots for each comination of dice rolls (2-12) For example, aResults[2] holds the total count of occurences when the sum of the 2 dice is 2.
            int[] aResults = new int[13];

            //based on the user input (iNumRolls), generate a random number between 1 and 6 for both dice
            for (int iCount = 0; iCount < iNumRolls; iCount++)
            {
                int iRandRoll1 = random.Next(1, 7);
                int iRandRoll2 = random.Next(1, 7);
                int iSum = iRandRoll1 + iRandRoll2;

                //add the value of the sum to the array
                aResults[iSum]++;
            }
            return aResults;
        }
    }
}