using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace akasztofa
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("szavak.txt");
            List<string> l = new List<string>();
            while (!sr.EndOfStream)
            {
                l.Add(sr.ReadLine());
            }
            Random r = new Random();
            String szo = l[r.Next(0,l.Count)];
            String allas = "";
            String ideiglenes = "";

            for (int i = 0; i < szo.Length; i++)
            {
                allas += "_";
            }
            bool megy = true;
            Console.WriteLine(allas);
            int szamolo = 0;
            while (megy)
            {
                Console.WriteLine("Választott betű:");
                char betu = Console.ReadKey().KeyChar;
                szamolo++;
                Console.WriteLine();
                for (int i = 0; i < szo.Length; i++)
                {
                    if (betu == szo[i])
                    {
                        ideiglenes += szo[i];
                    }
                    else
                    {
                        ideiglenes += allas[i];
                    }
                }
                allas = ideiglenes;
                ideiglenes = "";
                if (allas.Contains("_"))
                {
                    Console.WriteLine(allas + " (próbálkozás: " + szamolo + ")");
                    if (szamolo >= szo.Length + 5)
                    {
                        Console.WriteLine("Vesztettél! A szó a/az " + szo + " volt!");
                        megy = false;
                    }
                }
                else
                {
                    Console.WriteLine("Nyertél! A szó a/az " + szo + " volt! Gratulálok!");
                    megy = false;
                }
            }
            Console.ReadKey();
        }
    }
}
