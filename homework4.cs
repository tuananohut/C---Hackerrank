/*

Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle yazın:");
        string cumle = Console.ReadLine();
        
        int kelimeSayisi = 0;
        int harfSayisi = 0;
        
        foreach (char c in cumle)
        {
            if (c == ' ')
            {
                kelimeSayisi++;
            }
            else
            {
                harfSayisi++;
            }
        }
        
        // son kelimeyi saymak için kelime sayısını 1 artır
        kelimeSayisi++;
        
        Console.WriteLine("Toplam kelime sayısı: " + kelimeSayisi);
        Console.WriteLine("Toplam harf sayısı: " + harfSayisi);
    }
}
