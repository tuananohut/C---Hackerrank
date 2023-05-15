using System;

public class Program
{
    enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    public static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Tuesday;
        Console.WriteLine("Today is {0}.", today);
    }
}
