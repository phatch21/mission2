// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] args)
    {
        int numThrows = 0;

        Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
        numThrows = int.Parse(Console.ReadLine());
    }


}
