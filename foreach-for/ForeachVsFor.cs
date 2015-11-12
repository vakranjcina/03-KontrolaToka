using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace Vsite.CSharp
{
    class ForeachVsFor
    {
        static void Main(string[] args)
        {
            Random generatorSlučajnih = new Random();

            int brojElemenata = 200000;
            // prvo generiramo polje brojeva i popunimo ga
            double[] brojevi = new double[brojElemenata];
            for (int i = 0; i < brojElemenata; ++i)
                brojevi[i] = generatorSlučajnih.NextDouble();

            double zbroj = 0;

            Console.Write("Niz obilazimo foreach: ");

            // štoperica će mjeriti vrijeme potrebno za prolaz kroz sve elemente 
            Stopwatch stoperica = new Stopwatch();
            stoperica.Start();

            foreach (double broj in brojevi)
            {
                zbroj += broj;
            }

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);
            stoperica.Reset();

            Console.Write("Niz obilazimo for:     ");
            
            stoperica.Start();

            for (int i = 0; i < brojevi.Length; ++i)
            {
                zbroj += brojevi[i];
            }

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);

            List<double> listaBrojeva = new List<double>(brojevi);

            stoperica.Reset();
            Console.Write("Listu obilazimo for:     ");

            stoperica.Start();

            for (int i = 0; i < listaBrojeva.Count; ++i)
            {
                zbroj += listaBrojeva[i];
            }

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);
            stoperica.Reset();

            Console.Write("Listu obilazimo foreach: ");

            stoperica.Start();

            foreach (double broj in listaBrojeva)
            {
                zbroj += broj;
            }

            stoperica.Stop();
            Console.WriteLine(stoperica.ElapsedTicks);

            // Pokrenuti program 5 puta i sve ispise kopirati u datoteku "ForEachVsFor.txt" pridruženu ovom projektu.

            Console.ReadKey();

        }
    }
}
