using System;

namespace ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun bilgisayar = new Urun()
            {
                urunAdi = "bilgisayar",
                urunKategorisi = "Elektronik",
                urunFiyati = 3599.90
            };

            Urun cepTelefonu = new Urun()
            {
                urunAdi = "cepTelefonu",
                urunKategorisi = "Elektronik",
                urunFiyati = 7599.90
            };

            Urun saat = new Urun()
            {
                urunAdi = "saat",
                urunKategorisi = "Aksesuar",
                urunFiyati = 599.90
            };

            Urun ayakkabi = new Urun()
            {
                urunAdi = "ayakkabi",
                urunKategorisi = "Giyim",
                urunFiyati = 199.90
            };



            Urun[] urunler = new Urun[]{
                bilgisayar,
                cepTelefonu,
                saat,
                ayakkabi
            };
            Console.WriteLine("######   FOREACH   ######");
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunKategorisi + " | "
                                + urun.urunAdi + " | "
                                + urun.urunFiyati);
            };

            Console.WriteLine("######   FOR   ######");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunKategorisi + " | "
                                + urunler[i].urunAdi + " | "
                                + urunler[i].urunFiyati);
            };

            Console.WriteLine("######   WHILE   ######");
            int s = 0;
            while (s < urunler.Length)
            {
                Console.WriteLine(urunler[s].urunKategorisi + " | "
                                + urunler[s].urunAdi + " | "
                                + urunler[s].urunFiyati);
                s++;
            };
        }
    }
    class Urun
    {
        public string urunAdi { get; set; }
        public string urunKategorisi { get; set; }
        public double urunFiyati { get; set; }
    }
}