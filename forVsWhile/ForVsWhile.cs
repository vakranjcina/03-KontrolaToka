using System;

namespace Vsite.CSharp
{
    class ForVsWhile
    {
        static void Main(string[] args)
        {
            // Prevesti(buildati) program te programom ILDasm pogledati međukod. Pripadajući međukod kopirati u datoteke "Petlja for.txt", odnosno "Petlja while.txt" koje su dio projekta

            for (int i = 0; i < 10; ++i)
                Console.WriteLine(i);

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                ++j;
            }
        }
    }
}
