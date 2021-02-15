using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.AdSoyad = "Cemre Ant";
            musteri1.HesapNo = " 1212121212 ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.AdSoyad = "Levent Ant";
            musteri2.HesapNo = "898989898";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.AdSoyad = "Tülin Ant";
            musteri3.HesapNo = "56565656";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Silme(musteri1);
            musteriManager.Listele(musteri1);




        }
    }
}
