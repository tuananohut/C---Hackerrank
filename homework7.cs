using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine().ToLower();

        char[] sesliHarfler = new char[cumle.Length];
        int index = 0;

        for (int i = 0; i < cumle.Length; i++)
        {
            char harf = cumle[i];

            if (harf == 'a' || harf == 'e' || harf == 'i' || harf == 'o' || harf == 'u')
            {
                sesliHarfler[index] = harf;
                index++;
            }
        }

        Array.Resize(ref sesliHarfler, index);
        Array.Sort(sesliHarfler);

        Console.WriteLine("Cümledeki sesli harfler: ");
        foreach (char harf in sesliHarfler)
        {
            Console.Write(harf + " ");
        }
    }
}
