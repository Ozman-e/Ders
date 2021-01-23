using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Soyadi = "123456";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678";



            //gerçek(normal müşteri) - tüzel(şirket gibi) birbirinin yerine kullanılamaz.
            //SOLID

            Musteri musteri3 = new GercekMusteri(); // new demek ref no demek
            Musteri musteri4 = new TuzelMusteri(); // musteri classı hem gerçek hem tüzel müşterinin ref nosunu tutar.

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);


        }
    }
}
