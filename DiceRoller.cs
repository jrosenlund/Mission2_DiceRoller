using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2_DiceRoller
{
    internal class DiceRoller
    {
        public int[] Play(int iNumRolls)
        {
            Random random = new Random();

            // Initialize vars
            int[] results = [];
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;
            int seven = 0;
            int eight = 0;
            int nine = 0;
            int ten = 0;
            int eleven = 0;
            int twelve = 0;

            int die1 = 0;
            int die2 = 0;

            // Roll the dice
            for (int iRollCount = 0; iRollCount < iNumRolls; iRollCount++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);

                // Iterate the right variable according to the result
                if (die1 + die2 == 2)
                { two++; }
                else if (die1 + die2 == 3)
                { three++; }
                else if (die1 + die2 == 4)
                { four++; }
                else if (die1 + die2 == 5)
                { five++; }
                else if (die1 + die2 == 6)
                { six++; }
                else if (die1 + die2 == 7)
                { seven++; }
                else if (die1 + die2 == 8)
                { eight++; }
                else if (die1 + die2 == 9)
                { nine++; }
                else if (die1 + die2 == 10)
                { ten++; }
                else if (die1 + die2 == 11)
                { eleven++; }
                else if (die1 + die2 == 12)
                { twelve++; }
                else { System.Console.WriteLine("Something's wrong :("); }
            }

            // Compile results
            results = [two, three, four, five, six, seven, eight, nine, ten, eleven, twelve];

            return results;
        }
    }
}
