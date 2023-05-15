using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();

        string uppercaseText = text.ToUpper();

        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Uppercase text: " + uppercaseText);
    }
}
