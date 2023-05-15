using System;
using System.Collections.Generic;

namespace ToDoUygulamasi
{
    class Kart
    {
        public string Baslik;
        public string Icerik;
        public string Durum;

        public Kart(string baslik, string icerik, string durum)
        {
            Baslik = baslik;
            Icerik = icerik;
            Durum = durum;
        }
    }

    class Board
    {
        public string Baslik;
        public List<Kart> Kartlar;

        public Board(string baslik)
        {
            Baslik = baslik;
            Kartlar = new List<Kart>();
        }

        public void KartEkle(Kart yeniKart)
        {
            Kartlar.Add(yeniKart);
        }

        public void KartGuncelle(int index, Kart yeniKart)
        {
            Kartlar[index] = yeniKart;
        }

        public void KartSil(int index)
        {
            Kartlar.RemoveAt(index);
        }

        public void KartTasi(int eskiIndex, int yeniIndex)
        {
            var kart = Kartlar[eskiIndex];
            Kartlar.RemoveAt(eskiIndex);
            Kartlar.Insert(yeniIndex, kart);
        }

        public void Listele()
        {
            Console.WriteLine("Board: " + Baslik);

            foreach (var kart in Kartlar)
            {
                Console.WriteLine("Baslik: " + kart.Baslik);
                Console.WriteLine("Icerik: " + kart.Icerik);
                Console.WriteLine("Durum: " + kart.Durum);
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var board1 = new Board("TODO");
            var board2 = new Board("IN PROGRESS");
            var board3 = new Board("DONE");

            board1.KartEkle(new Kart("Ödevler", "Matematik ödevleri yapılacak", "TODO"));
            board1.KartEkle(new Kart("Kitap Okuma", "Yeni kitap okunacak", "TODO"));
            board2.KartEkle(new Kart("ToDo Uygulaması", "Console uygulaması geliştirilecek", "IN PROGRESS"));
            board3.KartEkle(new Kart("Sınav", "Fizik sınavı", "DONE"));

            board1.Listele();
            board2.Listele();
            board3.Listele();

            board1.KartTasi(0, 1);
            board3.KartGuncelle(0, new Kart("Sınav", "Kimya sınavı", "DONE"));
            board2.KartSil(0);

            board1.Listele();
            board2.Listele();
            board3.Listele();

            Console.ReadLine();
        }
    }
}
