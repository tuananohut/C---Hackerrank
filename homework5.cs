/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/


using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        int sayac = 0;

        while (sayac < 20)
        {
            Console.Write("Pozitif bir sayı giriniz: ");
            int sayi;
            if (int.TryParse(Console.ReadLine(), out sayi) && sayi > 0)
            {
                bool asalMi = true;

                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }

                sayac++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş! Tekrar deneyin.");
            }
        }

        asalSayilar.Sort();
        asalSayilar.Reverse();

        Console.WriteLine("\nAsal sayılar:");
        foreach (int sayi in asalSayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("\nAsal olmayan sayılar:");
        asalOlmayanSayilar.Sort();
        foreach (int sayi in asalOlmayanSayilar)
        {
            Console.WriteLine(sayi);
        }

        double asalSayilarOrt = asalSayilar.Count > 0 ? asalSayilar.Average() : 0;
        double asalOlmayanSayilarOrt = asalOlmayanSayilar.Count > 0 ? asalOlmayanSayilar.Average() : 0;

        Console.WriteLine("\nAsal sayıların sayısı: " + asalSayilar.Count);
        Console.WriteLine("Asal sayıların ortalaması: " + asalSayilarOrt);
        Console.WriteLine("Asal olmayan sayıların sayısı: " + asalOlmayanSayilar.Count);
        Console.WriteLine("Asal olmayan sayıların ortalaması: " + asalOlmayanSayilarOrt);

        Console.ReadLine();
    }
}
