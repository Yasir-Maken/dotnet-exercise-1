using System;

// Program takes name as input from user and print Hello! the user input name
public class InputOutput
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine(); // Reads what the user types

        Console.WriteLine($"Hello, {name}!"); // Displays a greeting with the input
    }
}