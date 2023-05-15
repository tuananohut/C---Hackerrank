using System;

class Program
{
    static void Main(string[] args)
    {
        const int size = 20;
        int[] numbers = new int[size];
        int[] largestNumbers = new int[3];
        int[] smallestNumbers = new int[3];
        int largestSum = 0;
        int smallestSum = 0;
        
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter number {i+1}: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                i--;
            }
        }
        
        Array.Sort(numbers);
        Array.Reverse(numbers);
        
        for (int i = 0; i < 3; i++)
        {
            largestNumbers[i] = numbers[i];
            largestSum += numbers[i];
        }
        
        for (int i = size - 1, j = 0; j < 3; i--, j++)
        {
            smallestNumbers[j] = numbers[i];
            smallestSum += numbers[i];
        }
        
        double largestAverage = (double)largestSum / 3;
        double smallestAverage = (double)smallestSum / 3;
        
        Console.WriteLine("\nLargest 3 numbers:");
        foreach (int number in largestNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"Average: {largestAverage}");
        
        Console.WriteLine("\nSmallest 3 numbers:");
        foreach (int number in smallestNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine($"Average: {smallestAverage}");
        
        Console.WriteLine($"\nTotal average: {(largestAverage + smallestAverage) / 2}");
    }
}
