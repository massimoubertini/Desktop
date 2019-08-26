using System;
using static System.Console;

internal class Due_Calcolatrice
{
    public static void Run()
    {
        // visualizzare il titolo come app per la calcolatrice della console di C#
        WriteLine("Calcolatrice console in C #\r");
        WriteLine("--------------------------\n");
        // chiedere all'utente di digitare il primo numero
        Write("Digitare un numero e quindi premere INVIO\t");
        // dichiarare le variabili
        float num1 = Convert.ToInt32(ReadLine());
        // chiedere all'utente di digitare il secondo numero
        Write("Digitare un altro numero e quindi premere INVIO\t");
        float num2 = Convert.ToInt32(ReadLine());
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
                WriteLine($"Il tuo risultato: {num1} / {num2} = " + (num1 / num2));
                break;
        }
    }
}