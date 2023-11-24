using System.Data;

namespace Calculator.Core;

internal class Engine
{
    public static void Start()
    {
        while (true)
        {
            Console.WriteLine("Gib eine Formel ein:");
            string input = Console.ReadLine();
            Logic logic = new();
            double rightresult = logic.CheckResult(input);
            double result = logic.Compute(input);
            Console.WriteLine(result);
            if (rightresult == result)
            {
                Console.WriteLine("Term ist richtig");
            }
            else
            {
                Console.WriteLine("Term ist falsch ausgerechnet");
            }

            Console.WriteLine("Enter drücken, um das Programm zu beenden, tippe \"Weiter\" in deiner Sprache um Weiter zu machen.");
            string option = Console.ReadLine();
           
            if (option == null)
            {
                Stop();
            }
        }
    }
    private static void Stop()
    {
        Environment.Exit(0);
    }
}
