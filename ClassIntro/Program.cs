using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Sercan";
            int yas = 26;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Sercan KURBAN";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Ahmet KARACA";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Yusuf KANDEMİR";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C++";
            kurs4.Egitmen = "Yeliz ASYA";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            }

            Console.ReadLine();

        }
    }

    class Kurs
    {
        // prop -> TAB+TAB
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
