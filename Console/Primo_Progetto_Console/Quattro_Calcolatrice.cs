using System;
using static System.Console;

internal class Quattro_Calcolatrice
{
    public static void Run()
    {
        // visualizzare il titolo come app per la calcolatrice della console di C#
        WriteLine("Calcolatrice console in C #\r");
        WriteLine("--------------------------\n");
        // chiedere all'utente di digitare il primo numero
        Write("Digitare un numero e quindi premere INVIO\t");
        // dichiarare le variabili
        double num1 = Convert.ToDouble(ReadLine());
        // chiedere all'utente di digitare il secondo numero
        Write("Digitare un altro numero e quindi premere INVIO\t");
        double num2 = Convert.ToDouble(ReadLine());
        // chiedere all'utente di scegliere un'opzione
        WriteLine("Scegliere un'opzione dall'elenco seguente:");
        WriteLine("\t1 - Somma");
        WriteLine("\t2 - Sottrazione");
        WriteLine("\t3 - Moltiplicazione");
        WriteLine("\t4 - Divisione");
        Write("La tua opzione? ");
        // utilizzare un'istruzione switch per eseguire le operazioni matematiche
        switch (ReadLine())
        {
            case "1":
                WriteLine($"Il tuo risultato: {num1} + {num2} = " + (num1 + num2));
                break;

            case "2":
                WriteLine($"Il tuo risultato: {num1} - {num2} = " + (num1 - num2));
                break;

            case "3":
                WriteLine($"Il tuo risultato: {num1} * {num2} = " + (num1 * num2));
                break;

            case "4":
                // chiedere all'utente d'immettere un divisore diverso da zero fino a quando non lo fa
                while (num2 == 0)
                {
                    Write("Immettere un divisore diverso da zero:\t");
                    num2 = Convert.ToInt32(ReadLine());
                }
                WriteLine($"Il tuo risultato: {num1} / {num2} = " + (num1 / num2));
                break;
        }
    }
}