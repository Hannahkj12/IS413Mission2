//Hannah Johnson IS 4013 Section 2
//This program simulates rolling two dice & shows the frequency of the totals based on the number of times that the user chooses to roll them.

using IS413Mission2;

class Program
{
    static void Main()
    {
        //print text in console
        //note: write prints on one line while writeline yeets the curser to the next line after
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Console.Write("How many dice rolls would you like to simulate? ");

        //takes the string input and tries to convert to a integer. If it's positive, the rest of the program can run
        if (int.TryParse(Console.ReadLine(), out int iNumRolls) && iNumRolls > 0)
        {
            //create an instance of diceRolls
            DiceRolls diceRolls = new DiceRolls();
            //uses instance diceRolls to call the method SimulateDiceRolls
            int[] aResults = diceRolls.SimulateDiceRolls(iNumRolls);

            //print out result to the console
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {iNumRolls}.\n");

            //calculate percent of total for each sum combo in the array
            for (int iCount = 2; iCount <= 12; iCount++)
            {
                //retrieves the count of occurrances (frequency) in the results array
                int iFrequency = aResults[iCount];
                double dPercentage = (iFrequency / (double)iNumRolls) * 100;

                //print out histogram
                Console.WriteLine($"{iCount}: {new string('*', (int)Math.Round(dPercentage))}");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
        //in the case that a user is silly...
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer for the number of rolls.");
        }
    }
}
