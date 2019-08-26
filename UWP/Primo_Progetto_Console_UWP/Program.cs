using System;
using static System.Console;

namespace Console_UWP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Clear();
            WriteLine("Ciao, mondo in UWP console app!");
            var parameters = string.Join(Environment.NewLine, args);
            if (string.IsNullOrEmpty(parameters))
                WriteLine("App invocata senza parametri.");
            else
                WriteLine($"App invocata con i parametri: {Environment.NewLine}{parameters}");
            ReadKey();
        }
    }
}