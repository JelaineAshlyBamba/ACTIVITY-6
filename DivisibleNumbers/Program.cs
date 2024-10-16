using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for input
        Console.Write("Enter the range limit (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor (d): ");
        int d = int.Parse(Console.ReadLine());

        // Initialize a flag to check if any number is divisible
        bool foundDivisible = false;

        // Loop through numbers from 1 to n
        Console.WriteLine($"Numbers divisible by {d} between 1 and {n}:");
        for (int i = 1; i <= n; i++)
        {
            if (i % d == 0)
            {
                Console.Write(i + " ");
                foundDivisible = true;
            }
        }

        // If no numbers were found, display a message
        if (!foundDivisible)
        {
            Console.WriteLine($"\nNo numbers between 1 and {n} are divisible by {d}.");
        }
        else
        {
            Console.WriteLine(); // for a new line after output
        }
    }
}
