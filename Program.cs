// See https://aka.ms/new-console-template for more information

using mission2;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        if (!int.TryParse(Console.ReadLine(), out int numRolls) || numRolls <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer.");
            return;
        }

        DiceSimulator simulator = new DiceSimulator();
        int[] rollResults = simulator.SimulateRolls(numRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = (int)Math.Round((double)rollResults[i] * 100 / numRolls);
            Console.WriteLine(i + ": " + new string('*', percentage));
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}


