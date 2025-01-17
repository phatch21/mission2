// Payton Hatch
// Group 4-6

// using statement connects this program with the rest of the project
using mission2;
internal class Program
{
    // creates constructor method
    static void Main(string[] args)
    {
        int numRolls = 0;

        // introduction and query for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        // stores number of rolls entered by the user
        numRolls = int.Parse(Console.ReadLine());

        // creates object from the DiceSimulator() method of the DiceRollingSimulator class
        DiceSimulator simulator = new DiceSimulator();
        int[] rollResults = simulator.SimulateRolls(numRolls);

        // message describing simulation results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        // for loop creating the histogram according to roll count
        for (int iCount = 2; iCount <= 12; iCount++)
        {   
            // calculates the percentage each count takes of the total number of rolls and prints it
            int percentage = (int)Math.Round((double)rollResults[iCount] * 100 / numRolls);
            Console.WriteLine(iCount + ": " + new string('*', percentage));
        }

        // final message
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}


