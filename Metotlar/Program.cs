using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1= new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Çilek";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Çilek gibi çilek";

            Urun[] urunler = new Urun[] { urun1,urun2};

            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi+":"+urun.Fiyati+"("+urun.Aciklama+")");
                Console.WriteLine("----------------------------------------");
                      
            }

            Console.WriteLine("----------------Metotlar----------------");
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 15);

            sepetManager.Ekle2("Elma", "Yeşil elma", 15);
            sepetManager.Ekle2("Mandalina", "Güzel mandalina", 15);

        }
    }
}
