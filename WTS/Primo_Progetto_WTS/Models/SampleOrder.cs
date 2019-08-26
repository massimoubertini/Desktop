using System;

namespace Meteo.Models
{
    /* rimuovere questa classe una volta che le pagine/caratteristiche utilizzano i dati
     * è utilizzato da SampleDataService, è la classe del modello che usiamo per
     * visualizzare i dati nelle pagine come Grid, Chart e Master Detail  */

    public class SampleOrder
    {
        public long OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Company { get; set; }

        public string ShipTo { get; set; }

        public double OrderTotal { get; set; }

        public string Status { get; set; }

        public char Symbol { get; set; }

        public override string ToString()
        {
            return $"{Company} {Status}";
        }
    }
}
