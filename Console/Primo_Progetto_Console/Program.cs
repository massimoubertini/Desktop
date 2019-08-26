using System;
using static System.Console;

namespace Calcolatrice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Clear();
            //Uno_Calcolatrice.Run();
            //Due_Calcolatrice.Run();
            //Tre_Calcolatrice.Run();
            //Quattro_Calcolatrice.Run();
            //*******************************************
            ConsoleKeyInfo cki;
            do
            {
                Clear();
                // visualizzare il titolo come app per la calcolatrice della console di C#
                WriteLine("Calcolatrice console in C #\r");
                WriteLine("--------------------------\n");
                // dichiarare le variabili e impostarle a nulle
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;
                // chiedere all'utente di digitare il primo numero
                Write("Digitare un numero e quindi premere INVIO\t\t\t");
                numInput1 = ReadLine();
                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Write("Questo non è un input valido. Immettere un valore numerico:\t");
                    numInput1 = ReadLine();
                }
                // chiedere all'utente di digitare il secondo numero
                Write("Digitare un altro numero e quindi premere INVIO\t\t\t");
                numInput2 = ReadLine();
                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Write("Questo non è un input valido. Immettere un valore numerico:\t");
                    numInput2 = ReadLine();
                }
                // chiedere all'utente di scegliere un'opzione
                WriteLine("Scegliere un'opzione dall'elenco seguente:");
                WriteLine("\t1 - Somma");
                WriteLine("\t2 - Sottrazione");
                WriteLine("\t3 - Moltiplicazione");
                WriteLine("\t4 - Divisione");
                Write("La tua opzione? ");
                string op = ReadLine();
                try
                {
                    result = Refactoring_Calcolatrice.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                        WriteLine("Questa operazione comporterà un errore matematico!\n");
                    else
                        WriteLine("Il tuo risultato: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    WriteLine("Si è verificata un'eccezione durante i calcoli!\n - Dettagli: " + e.Message);
                }
                WriteLine("------------------------\n");
                // attendere che l'utente risponda prima della chiusura
                Write("Premere ESC per terminare, un tasto qualsiasi per continuare.");
                cki = ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}