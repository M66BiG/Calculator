using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gib eine Formel ein:");
        string input = Console.ReadLine();

        try
        {
            double result = RemoveSpaces(input);
            Console.WriteLine($"Ergebnis: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
        }
    }
}

  