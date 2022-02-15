using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szótár_halmazok
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 2, 6, 2, 5, 2, 4, 2, 3, 2, 1, 2, 7, 2, 8, 2, 9};
            HashSet<int> halmaz = new HashSet<int>();
            //Ez felel meg, amit matrematikában használunk
            //1. Ha a halmazban van már egy elem, akkor abba bele rakva 
            //2. A halmazban nincs ilyen sorrend--nincs indexxelés

            Console.WriteLine(halmaz.Count);
            halmaz.Add(2);
            Console.WriteLine(halmaz.Count);
            halmaz.Add(3);
            Console.WriteLine(halmaz.Count);
            halmaz.Add(2);
            Console.WriteLine(halmaz.Count);


            //Hozzáválogatjuk a különböző elemeket
            for (int i = 0; i < lista.Count; i++)
            {
                halmaz.Add(lista[i]);
            }
            Console.WriteLine(halmaz.Count);

            halmaz.Remove(3);
            Console.WriteLine(halmaz.Count);
            //Halmaz 0. elemet nem lehet kérni, mert nincs sorrend

            //Kiírom a lisdta összes elemét
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write($"{ lista[i]}");
            }

            Console.WriteLine();
            //Nem indexeken megxy keresztül, hanem elemeken, nincs sorrend, elemeket kell kiírni!!!
            foreach (int elem in lista)
            {
                Console.Write($"{elem}");
            }
            Console.WriteLine();


            Console.WriteLine(halmaz.Contains(2)); //Tartalmazza-e ezt az elemet

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //angol német szótár
            Dictionary<string, string> angolnemetszótár = new Dictionary<string, string>();
            angolnemetszótár["one"] = "eins";
            angolnemetszótár["two"] = "zwei";
            angolnemetszótár["thee"] = "drei";
            Console.WriteLine(angolnemetszótár["three"]);
            Console.WriteLine(angolnemetszótár["one"]);

            foreach  (string kulcs in angolnemetszótár.Keys)
            {
                Console.WriteLine($"{kulcs}->{angolnemetszótár[kulcs]}");
            }



            Console.ReadKey();
        }
    }
}
