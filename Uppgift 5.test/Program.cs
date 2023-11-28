using System;
using System.Diagnostics;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            double[] ålder = new double[5];
            double storst = 0;
            string äldstanamn = "";
            for (int i = 0; i < namn.GetLength(0); i++)
            {
                Console.WriteLine("Skriv namn på klasskamrat " + (i + 1));
                namn[i] = Console.ReadLine();
                Console.WriteLine("Skriv deras ålder: ");
                ålder[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i < namn.GetLength(0); i++)
            {
                if (ålder[i] > storst)
                {
                    storst = ålder[i];
                    äldstanamn = namn[i];
                }
            }
            Console.WriteLine("Medelåldern är = " + (ålder[0] + ålder[1] + ålder[2] + ålder[3] + ålder[4]) / 5);
            Console.WriteLine("Äldsta i klassen är " + äldstanamn + " som är " + storst + " år");
        }
    }
}