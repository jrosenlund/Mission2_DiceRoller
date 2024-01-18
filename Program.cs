using Mission2_DiceRoller;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        // Function to add asterisks
        string histAsterisks(int numRolls, int totRolls)
        {
            string asterisks = "";

            double doubleRolls = (double)numRolls;
            double doubleTot = (double)totRolls;

            double percent = (doubleRolls / doubleTot) * 100;

            for (int i = 0; i < percent; i++)
            {
                asterisks = asterisks + "*";
            }

            return asterisks;
        }

        // Create reference to DiceRoller class
        DiceRoller roll = new DiceRoller();

        // Initialize dice roller vars
        int iNumRolls = 0;
        int[] aResults = [];

        // Get user input
        System.Console.WriteLine("Welcome to the Dice Rolling Simulator!");
        System.Console.WriteLine("How many times would you like to roll the dice?");
        iNumRolls = int.Parse(Console.ReadLine());

        // Give desired rolls to the play method and collect the results
        aResults = roll.Play(iNumRolls);

        // Print results
        System.Console.WriteLine("\nDICE ROLLING SIMULATOR RESULTS\n");
        System.Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + iNumRolls.ToString() + "\n");

        // For each result, get the asterisks for a histogram
        System.Console.WriteLine("2: " + histAsterisks(aResults[0], iNumRolls));
        System.Console.WriteLine("3: " + histAsterisks(aResults[1], iNumRolls));
        System.Console.WriteLine("4: " + histAsterisks(aResults[2], iNumRolls));
        System.Console.WriteLine("5: " + histAsterisks(aResults[3], iNumRolls));
        System.Console.WriteLine("6: " + histAsterisks(aResults[4], iNumRolls));
        System.Console.WriteLine("7: " + histAsterisks(aResults[5], iNumRolls));
        System.Console.WriteLine("8: " + histAsterisks(aResults[6], iNumRolls));
        System.Console.WriteLine("9: " + histAsterisks(aResults[7], iNumRolls));
        System.Console.WriteLine("10: " + histAsterisks(aResults[8], iNumRolls));
        System.Console.WriteLine("11: " + histAsterisks(aResults[9], iNumRolls));
        System.Console.WriteLine("12: " + histAsterisks(aResults[10], iNumRolls));

        System.Console.WriteLine("\nThank you for using the dice rolling simulator. Goodbye!");
    }
}