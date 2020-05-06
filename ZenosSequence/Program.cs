using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiagZenona
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("LP", "Wartość wyrazu ciągu", "Suma w przybliżeniu");
            Console.Write("Ile elementów ciągu mam wypisać (od 1 do 101): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pierwsze {n} wyrazów ciągu i ich sumy");
            double w = 100;
            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += w;
                //Console.WriteLine($"{i} wyraz ciągu: {w} SUMA = {suma}");
                table.AddRow(i, w, suma);
                w = w / 2;
            }
            table.Write(Format.Alternative);
            Console.ReadLine();
        }
    }
}
