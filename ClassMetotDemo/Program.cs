using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Fatma Özlem";
            musteri1.MusteriSoyad = "Acar";
            musteri1.MusteriMaas = 17500;
            musteri1.KrediTipi = "İhtiyaç Kredisi";
            musteri1.MusteriMeslek = "Grafik Tasarımcısı";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Atahan";
            musteri2.MusteriSoyad = "Adanır";
            musteri2.MusteriMaas = 22500;
            musteri2.KrediTipi = "Taşıt Kredisi";
            musteri2.MusteriMeslek = "Yazılım Geliştirme Uzman Yardımcısı";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "Mehmetcan";
            musteri3.MusteriSoyad = "Akay";
            musteri3.MusteriMaas = 19500;
            musteri3.KrediTipi = "Konut Kredisi";
            musteri3.MusteriMeslek = "İç Mimar";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriAd = "Rana";
            musteri4.MusteriSoyad = "Altınoklu";
            musteri4.MusteriMaas = 32500;
            musteri4.KrediTipi = "Taşıt Kredisi";
            musteri4.MusteriMeslek = "İş Zekası Uzmanı";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            Console.WriteLine("Banka Müşteri Listesi ve Başvuru Bilgileri:");
            Console.WriteLine("----------------------");

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ". Müşteri Bilgileri : ");
                Console.WriteLine("Adı/Soyadı : " + musteri.MusteriAd + " " + musteri.MusteriSoyad);
                Console.WriteLine("Mesleği/Maaşı : " + musteri.MusteriMeslek + " / " + musteri.MusteriMaas + " TL");
                Console.WriteLine("Çekilmek istenilen kredi tipi : " + musteri.KrediTipi);
                Console.WriteLine("");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteriler);
            Console.WriteLine("");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("");
            musteriManager.Cikar(musteri3);
        }
    }
}