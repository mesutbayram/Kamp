using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mesut";
            int yas = 29;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Mesut BAYRAM";
            kurs1.IzlenmeOrani = 36;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mesut BAYRAM";
            kurs2.IzlenmeOrani = 12;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mesut BAYRAM";
            kurs3.IzlenmeOrani = 28;

            Console.WriteLine(kurs1.KursAdi + " | " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1, kurs2, kurs3
            };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " | " + kurs.Egitmen);
            }
            
            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
