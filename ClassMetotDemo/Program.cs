using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TcNo = 11111111111;
            musteri1.Adi = "AAAAA";
            musteri1.Soyadi = "AAAAA";
            musteri1.Hesap = 1;

            Musteri musteri2 = new Musteri();
            musteri2.TcNo = 22222222222;
            musteri2.Adi = "BBBBB";
            musteri2.Soyadi = "BBBBB";
            musteri2.Hesap = 2;

            Musteri musteri3 = new Musteri();
            musteri3.TcNo = 33333333333;
            musteri3.Adi = "CCCCC";
            musteri3.Soyadi = "CCCCC";
            musteri3.Hesap = 3;

            MusteriOzelligi musteriOzelligi = new MusteriOzelligi();
            musteriOzelligi.Ekle(musteri1);
          //  musteriOzelligi.Sil(musteri2);
          //  musteriOzelligi.Listele(musteri1);
        }
    }
}
