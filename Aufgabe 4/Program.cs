namespace Aufgabe_4
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib einen Monat als Zahl ein:");
        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int monat))
        {
            if (monat == 1)
            {
                Console.WriteLine("Januar");
            }
            else if (monat == 2)
            {
                Console.WriteLine("Februar");
            }
            else if (monat == 3)
            {
                Console.WriteLine("März");
            }
            else if (monat == 4)
            {
                Console.WriteLine("April");
            }
            else if (monat == 5)
            {
                Console.WriteLine("Mai");
            }
            else if (monat == 6)
            {
                Console.WriteLine("Juni");
            }
            else if (monat == 7)
            {
                Console.WriteLine("Juli");
            }
            else if (monat == 8)
            {
                Console.WriteLine("August");
            }
            else if (monat == 9)
            {
                Console.WriteLine("September");
            }
            else if (monat == 10)
            {
                Console.WriteLine("Oktober");
            }
            else if (monat == 11)
            {
                Console.WriteLine("November");
            }
            else if (monat == 12)
            {
                Console.WriteLine("Dezember");
            }
            else
            {
                Console.WriteLine("Fehler: Bitte eine Zahl von 1 bis 12 eingeben!");
            }
        }
        else
        {
            Console.WriteLine("Das war keine gültige Zahl!");
        }
    }
}
}