public static class MathHelper
{
    public static int GetNextPrime(int number)
    {
        if (number < 2)
            return 2;

        for (int i = 2; i <= Math.Sqrt(number) + 1; i++)
        {
            if (number % i == 0)
            {
                return GetNextPrime(number + 1);
            }
        }

        return number;
    }

    public static int GetFactorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Number must be non-negative.");

        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}
