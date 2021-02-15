using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " No'lu Müşteri Eklendi" );
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine( musteri.AdSoyad+ " No'lu Müşteri Listelendi");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.HesapNo + " No'lu Müşteri Silindi");
        }
    }
    
}
