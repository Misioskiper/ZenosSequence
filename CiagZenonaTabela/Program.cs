using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiagZenonaTabela
{
    class Program
    {
        static int tableWidth = 73;

        static void Main(string[] args)
        {
            double w = 100;
            double suma = 0;
            Console.Clear();
            Console.Write("Ile elementów ciągu mam wypisać (od 1 do 101): ");
            int n = int.Parse(Console.ReadLine());
            PrintLine();
            PrintRow("LP", "Wartość wyrazu ciągu", "Suma w przybliżeniu");
            PrintLine();
            for (int i = 1; i <= n; i++)
            {
                suma += w;
                PrintRow(i.ToString(), w.ToString(), suma.ToString());
                w = w / 2;
            }
            //PrintRow("", "", "", "");
            
            PrintLine();
            Console.ReadLine();
        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}
