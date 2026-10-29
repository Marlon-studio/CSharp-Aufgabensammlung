namespace Aufgabe_2
using System;

namespace MonatsRechner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int zahl = 0;
            bool gueltig = false;

            while (!gueltig)
            {
                Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen? (Erlaubt: 28, 29, 30, 31)");
                string eingabe = Console.ReadLine();

               
                if (int.TryParse(eingabe, out zahl) && (zahl == 28 || zahl == 29 || zahl == 30 || zahl == 31))
                {
                    gueltig = true;
                }
                else
                {
                    Console.WriteLine("Fehler: Ungültige Eingabe! Erlaubt sind nur 28, 29, 30 oder 31.\n");
                }
            }

           
            int sekunden = zahl * 24 * 60 * 60;
            Console.WriteLine($"Ihr Monat hat {sekunden} Sekunden.");
            // hier war Fabrizio
        }
    }
}
