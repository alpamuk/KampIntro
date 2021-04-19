using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] kurslar = new string[] { "java", "react", "c#" };

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Alpaslan";
            kurs1.KursAdi = "React";

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Emre";
            kurs2.KursAdi = "Java";

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2  };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string  Egitmen { get; set; }
    }
}
