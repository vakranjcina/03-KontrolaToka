using System;

namespace Vsite.CSharp
{
    class PetljeWhileDoWhile
    {
        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            int brojBacanja = 0;
            int bacanje = 0;
            // Napisati simulaciju početka igre "Čovječe ne ljuti se": kocka se baca sve dok ne padne na 6
            do
            {
                ++brojBacanja;
                bacanje = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0}. pokušaj: {1}", brojBacanja, bacanje);
            } while (bacanje != 6);

            int brojPređenihPolja = brojBacanja;
            // Napisati petlju u kojoj se kocka baca sve dok brojPređenihPolja ne postane veći od 12
            while (brojPređenihPolja <= 12)
            {
                bacanje = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0} + {1}", brojPređenihPolja, bacanje);
                brojPređenihPolja += bacanje;
            }

            Console.WriteLine("Zbroj = {0}", brojPređenihPolja);

            Console.ReadKey();

            // pokrenite program, provjerite njegovu ispravnost i ispis prekopirajte u datoteku "PetljeWhileDoWhile.txt" koja je pridružena ovom projektu
        }

    }
}
