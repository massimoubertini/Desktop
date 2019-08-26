internal class Refactoring_Calcolatrice
{
    public static double DoOperation(double num1, double num2, string op)
    {
        /* il valore di default è NaN (Not-a-Number) che usiamo se un'operazione,
         * ad esempio la divisione, potrebbe generare un errore */
        double result = double.NaN;
        // utilizzare un'istruzione switch per eseguire le operazioni matematiche
        switch (op)
        {
            case "1":
                result = num1 + num2;
                break;

            case "2":
                result = num1 - num2;
                break;

            case "3":
                result = num1 * num2;
                break;

            case "4":
                // chiedere all'utente d'immettere un divisore diverso da zero fino a quando non lo fa
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // restituisce il testo per una voce di opzione non corretta
            default:
                break;
        }
        return result;
    }
}