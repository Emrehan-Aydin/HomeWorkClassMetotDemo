using System;

namespace HomeWorkClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                MusteriId = 1,
                MusteriAd = "Engin",
                MusteriSoyad = "Demiroğ"
            };
            Musteri musteri2 = new Musteri()
            {
                MusteriId = 2,
                MusteriAd = "Emrehan",
                MusteriSoyad = "AYDIN"
            };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Delete(musteri2);
        }
    }
}
