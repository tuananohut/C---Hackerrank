using System;

public static class ExtensionMethods
{
    public static int ToDecimal(this string number, int baseNumber)
    {
        int result = 0;
        int power = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = GetDigitValue(number[i]);
            result += digit * power;
            power *= baseNumber;
        }

        return result;
    }

    private static int GetDigitValue(char c)
    {
        if (c >= '0' && c <= '9')
        {
            return c - '0';
        }
        else
        {
            return c - 'A' + 10;
        }
    }
}

public class Program
{
    public static void Main()
    {
        string number = "1A7";
        int baseNumber = 16;

        int decimalNumber = number.ToDecimal(baseNumber);

        Console.WriteLine("Decimal representation: " + decimalNumber);
        Console.WriteLine("Reversed decimal number:");
        PrintReversed(decimalNumber);
    }

    public static void PrintReversed(int number)
    {
        if (number == 0)
        {
            return;
        }

        int digit = number % 10;
        Console.Write(digit);

        PrintReversed(number / 10);
    }
}
