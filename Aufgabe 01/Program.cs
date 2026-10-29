namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib die erste Zahlen ein");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Gib die zweite Zahlen ein");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());
        

            Console.WriteLine($"Das ergebnis aus {Zahl1} und {Zahl2} ist {Zahl1 + Zahl2}");
        }
    }
}
