using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        
        // Bir ArrayList oluşturuluyor
        ArrayList myArrayList = new ArrayList();
        
        // ArrayList'e elemanlar ekleme
        myArrayList.Add("Merhaba");
        myArrayList.Add("Dünya");
        myArrayList.Add(42);
        myArrayList.Add(true);
        
        // ArrayList elemanlarına erişim
        Console.WriteLine("ArrayList'in 3. elemanı: " + myArrayList[2]); // 42
        Console.WriteLine("ArrayList'in 4. elemanı: " + myArrayList[3]); // True
        
        // ArrayList boyutu
        Console.WriteLine("ArrayList eleman sayısı: " + myArrayList.Count); // 4
        
        // ArrayList elemanlarını dolaşma
        foreach (object element in myArrayList) {
            Console.WriteLine(element);
        }
        
        // ArrayList'den eleman çıkarma
        myArrayList.Remove(42);
        Console.WriteLine("42 çıkarıldıktan sonra ArrayList eleman sayısı: " + myArrayList.Count); // 3
        
        // ArrayList'in tamamını temizleme
        myArrayList.Clear();
        Console.WriteLine("ArrayList temizlendikten sonra eleman sayısı: " + myArrayList.Count); // 0
    }
}

