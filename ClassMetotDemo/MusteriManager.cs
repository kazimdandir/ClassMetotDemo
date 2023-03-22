using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " müşteriler listesine eklenmiştir.");
        }

        public void Cikar(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + musteri.MusteriSoyad + " müşteriler listesinden çıkarılmıştır.");
        }
        
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler listeleniyor... " + musteriler.Length + " müşteri bulunmuştur: ");
            
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ". Müşteri : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
            }
        }
     
    }
}
