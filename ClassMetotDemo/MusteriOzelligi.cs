using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriOzelligi
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(musteri.TcNo + "---" + musteri.Adi + " " + musteri.Soyadi + "*" + musteri.Hesap + " $");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("---------------------Liste---------------------");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(musteri.TcNo + "---" + musteri.Adi + " " + musteri.Soyadi + "*" + musteri.Hesap + " $");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine(musteri.TcNo + "---" + musteri.Adi + " " + musteri.Soyadi + "*" + musteri.Hesap + " $");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
