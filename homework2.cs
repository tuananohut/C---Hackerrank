using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n, m;

        Console.WriteLine("Birinci sayi: ");
        n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n]; // dizi oluşturulurken doğru syntax kullanıldı

        Console.WriteLine("Ikinci sayi: ");
        m = int.Parse(Console.ReadLine());

        Console.WriteLine("Birinci sayi kadar sayi giriniz");

        for(int i = 0; i < n; i++){
            Console.WriteLine("Sayi giriniz:"); // kullanıcıya sayı girmesi istenir
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for(int i = 0; i < n; i++){
            if(numbers[i] % m == 0){
                Console.WriteLine(numbers[i]);
            }
        }

    }
}
