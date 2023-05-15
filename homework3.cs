/*
Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n, i;
        
        n = int.Parse(Console.ReadLine());
        
        string[] words = new string[n];
    
        for(i = 0; i < n; i++){
            words[i] = Console.ReadLine();
        }
        
        Console.WriteLine("-------------------------");
        
        for(i = words.Length - 1; i >= 0; i--){
            Console.WriteLine(words[i]);
        }
        
    }
}
