/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
olduğu sayılardan çift olanlar console'a yazdırın.
*/


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
            int n, i;
            
            Console.WriteLine("Enter a number:");
            
            n = int.Parse(Console.ReadLine());
            
            int[] numbers = new int[n];
            
            for(i = 0; i < n; i++){
                Console.WriteLine($"{i} : ");
                numbers[i] = int.Parse(Console.ReadLine());;
            }
            
            for(i = 0; i < n; i++){
                if(numbers[i] % 2 == 0){
                    Console.WriteLine(numbers[i]);
                }
            }
    }
}
