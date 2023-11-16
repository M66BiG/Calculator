namespace Calculator.Core;

internal class Engine
{
    public static void Start()
    {
        Console.WriteLine("Gib eine Formel ein:");
        string input = "2*(5+(9*10))*(2+4)";
        Logic logic = new();
        logic.Compute(input);
        /*
        try
        {
            double result = logic.Compute(input);
            Console.WriteLine($"Ergebnis: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
        }*/
        
    }
    public static void Stop()
    {
        Environment.Exit(0);
    }
}
