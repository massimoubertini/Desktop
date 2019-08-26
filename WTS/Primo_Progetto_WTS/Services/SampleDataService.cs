using Meteo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Meteo.Services
{
    /* questa classe contiene i dati di esempio utilizzati da alcune pagine
     * generate per mostrare come possono essere utilizzati
     * elimina questo file una volta che l'app utilizza dati reali */

    public static class SampleDataService
    {
        private static IEnumerable<SampleOrder> AllOrders()
        {
            // di seguito sono riportati i dati riepilogativi dell'ordine
            var data = new ObservableCollection<SampleOrder>
            {
                new SampleOrder
                {
                    OrderId = 70,
                    OrderDate = new DateTime(2017, 05, 24),
                    Company = "Azienda F",
                    ShipTo = "Francisco Pérez-Olaeta",
                    OrderTotal = 2490.00,
                    Status = "Closed",
                    // Symbol.Globe
                    Symbol = (char)57643
                },
                new SampleOrder
                {
                    OrderId = 71,
                    OrderDate = new DateTime(2017, 05, 24),
                    Company = "Azienda C",
                    ShipTo = "Soo Jung Lee",
                    OrderTotal = 1760.00,
                    Status = "Closed",
                    // Symbol.Audio
                    Symbol = (char)57737
                },
                new SampleOrder
                {
                    OrderId = 72,
                    OrderDate = new DateTime(2017, 06, 03),
                    Company = "Azienda Z",
                    ShipTo = "Run Liu",
                    OrderTotal = 2310.00,
                    Status = "Closed",
                    // Symbol.Calendar
                    Symbol = (char)57699
                },
                new SampleOrder
                {
                    OrderId = 73,
                    OrderDate = new DateTime(2017, 06, 05),
                    Company = "Azienda Y",
                    ShipTo = "John Rodman",
                    OrderTotal = 665.00,
                    Status = "Closed",
                    // Symbol.Camera
                    Symbol = (char)57620
                },
                new SampleOrder
                {
                    OrderId = 74,
                    OrderDate = new DateTime(2017, 06, 07),
                    Company = "Azienda H",
                    ShipTo = "Elizabeth Andersen",
                    OrderTotal = 560.00,
                    Status = "Shipped",
                    // Symbol.Clock
                    Symbol = (char)57633
                },
                new SampleOrder
                {
                    OrderId = 75,
                    OrderDate = new DateTime(2017, 06, 07),
                    Company = "Azienda F",
                    ShipTo = "Francisco Pérez-Olaeta",
                    OrderTotal = 810.00,
                    Status = "Shipped",
                    // Symbol.Contact
                    Symbol = (char)57661
                },
                new SampleOrder
                {
                    OrderId = 76,
                    OrderDate = new DateTime(2017, 06, 11),
                    Company = "Azienda I",
                    ShipTo = "Sven Mortensen",
                    OrderTotal = 196.50,
                    Status = "Shipped",
                     // Symbol.Favorite
                    Symbol = (char)57619
                },
                new SampleOrder
                {
                    OrderId = 77,
                    OrderDate = new DateTime(2017, 06, 14),
                    Company = "Azienda B",
                    ShipTo = "Amritansh Raghav",
                    OrderTotal = 270.00,
                    Status = "New",
                    // Symbol.Home
                    Symbol = (char)57615
                },
                new SampleOrder
                {
                    OrderId = 78,
                    OrderDate = new DateTime(2017, 06, 14),
                    Company = "Azienda A",
                    ShipTo = "Anna Bedecs",
                    OrderTotal = 736.00,
                    Status = "New",
                    // Symbol.Mail
                    Symbol = (char)57625
                },
                new SampleOrder
                {
                    OrderId = 79,
                    OrderDate = new DateTime(2017, 06, 18),
                    Company = "Azienda K",
                    ShipTo = "Peter Krschne",
                    OrderTotal = 800.00,
                    Status = "New",
                    // Symbol.OutlineStar
                    Symbol = (char)57806
                },
            };

            return data;
        }

        // rimuove questo una volta che la pagina grafico sta visualizzando dati reali
        public static ObservableCollection<DataPoint> GetChartSampleData()
        {
            var data = AllOrders().Select(o => new DataPoint() { Category = o.Company, Value = o.OrderTotal })
                                  .OrderBy(dp => dp.Category);
            return new ObservableCollection<DataPoint>(data);
        }
    }
}
