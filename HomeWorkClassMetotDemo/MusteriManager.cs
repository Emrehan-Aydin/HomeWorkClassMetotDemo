using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> Musteriler;
        public MusteriManager()
        {
            Musteriler = new List<Musteri>();
        }
        public void Add(Musteri Person)
        {
            Musteriler.Add(Person);
            ShowList();
            Console.WriteLine("{0} Numaralı Musteri Eklendi!\n", Person.MusteriId);

        }
        public void Delete(Musteri Person)
        {
            Musteriler.Remove(Person);
            ShowList();
            Console.WriteLine("{0} Numaralı Musteri Silindi!\n", Person.MusteriId);
        }
        public void ShowList()
        {
            foreach (var item in Musteriler)
            {
                Console.WriteLine("{0} {1} {2} ", item.MusteriId, item.MusteriAd, item.MusteriSoyad);
            }

        }
    }
}
