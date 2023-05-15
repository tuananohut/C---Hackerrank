using System;
using System.Collections.Generic;

class Kisi {
public string ad;
public string soyad;
public string telefon;
}

class Rehber {
public List<Kisi> kisiler = new List<Kisi>();

public void kisi_ekle(Kisi yeni_kisi) {
    kisiler.Add(yeni_kisi);
}

public void kisi_sil(int index) {
    kisiler.RemoveAt(index);
}

public void kisi_guncelle(int index, Kisi yeni_kisi) {
    kisiler[index] = yeni_kisi;
}

public int rehberde_ara(string ad) {
    for (int i = 0; i < kisiler.Count; i++) {
        if (kisiler[i].ad == ad) {
            return i;
        }
    }
    return -1;
}

public void rehber_listele(bool ters_sirali = false) {
    List<Kisi> sirali_kisiler = kisiler;
    if (ters_sirali) {
        sirali_kisiler.Sort((x, y) => y.ad.CompareTo(x.ad));
    } else {
        sirali_kisiler.Sort((x, y) => x.ad.CompareTo(y.ad));
    }
    foreach (Kisi kisi in sirali_kisiler) {
        Console.WriteLine(kisi.ad + " " + kisi.soyad + " - " + kisi.telefon);
    }
}

}

class Program {
static void Main(string[] args) {
Rehber rehber = new Rehber();

    // Kişi ekleme:
    Kisi kisi1 = new Kisi { ad = "Ahmet", soyad = "Yılmaz", telefon = "555-1234" };
    Kisi kisi2 = new Kisi { ad = "Ayşe", soyad = "Kara", telefon = "555-5678" };
    rehber.kisi_ekle(kisi1);
    rehber.kisi_ekle(kisi2);

    // Arama:
    Console.WriteLine("\nArama sonuçları:");
    int aranan_index = rehber.rehberde_ara("Ayşe");
    if (aranan_index == -1) {
        Console.WriteLine("Kişi bulunamadı.");
    } else {
        Console.WriteLine(rehber.kisiler[aranan_index].ad + " " + rehber.kisiler[aranan_index].soyad + " - " + rehber.kisiler[aranan_index].telefon);
    }

    // Kişi güncelleme:
    Kisi yeni_kisi = new Kisi { ad = "Ayşe", soyad = "Demir", telefon = "555-8765" };
    rehber.kisi_guncelle(1, yeni_kisi);

    // Rehberi listeleme (Z-A):
    Console.WriteLine("\nRehber (Z-A):");
    rehber.rehber_listele(true);

    // Kişi silme:
    rehber.kisi_sil(1);

    // Rehberi listeleme:
    Console.WriteLine("\nRehber (A-Z):");
    rehber.rehber_listele();
}
}

