namespace Aufgabe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out int Kilometer))
            {
                if (Kilometer > 42)
                {
                    Console.WriteLine("Das schaffst du nicht");
                }
                else
                {
                    // Runden berechnen (1 Runde = 400 Meter)
                    int runden = (Kilometer * 1000) / 400;

                    Console.WriteLine($"Das sind {runden} Runden. Bereit für den Lauf?");
                    eingabe = Console.ReadLine(); // Eingabe für "ja" wiederverwenden

                    if (eingabe != null && eingabe.ToLower() == "ja")
                    {
                        int i = 1;

                        while (i <= runden)
                        {
                            Console.WriteLine($"Du läufst Runde {i}");
                            i++; // Wichtig, damit die Schleife nicht endlos läuft
                        }

                        Console.WriteLine("Du hast es geschafft!");
                    }
                    else
                    {
                        Console.WriteLine("Kein Problem, vielleicht ein anderes Mal!");
                    }
                }
            }
        }
    }
}