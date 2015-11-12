using System;

namespace Vsite.CSharp
{
    class NaredbeBreakContinue
    {
        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            int zbroj = 0;

            while (zbroj < 100)
            {
                int slučajniBroj = generatorSlučajnih.Next(2, 15); // generira slučajni broj između 2 i 14
                Console.WriteLine(slučajniBroj);

                // ako je broj paran, ne dodaje se (tj. treba se vratiti na početak petlje)
                if (slučajniBroj%2 == 0)
                    continue;

                // ako je broj dijeljiv s 12, tada treba prekinuti petlju
                if (slučajniBroj%12 == 0)
                    break;

                Console.WriteLine("{0} + {1}", zbroj, slučajniBroj);
                zbroj += slučajniBroj;
                Console.WriteLine(" ");
            }

            Console.WriteLine("Zbroj = {0}", zbroj);

            // Pokrenite program, provjerite njegovu ispravnost a ispis prekopirajte u datoteku "Naredbe break i continue.txt" koja je dio projekta

            Console.ReadKey();
        }
    }
}
