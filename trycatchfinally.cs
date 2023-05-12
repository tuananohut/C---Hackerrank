// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try
{
    int a = int.Parse(Console.ReadLine());

    int b = int.Parse(Console.ReadLine());

    int c = a+b;

    Console.WriteLine(c);
}
catch(Exception ex)
{
    Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}
    }
}
