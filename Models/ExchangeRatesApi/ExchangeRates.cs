using System;
using System.Collections.Generic;

namespace Models.ExchangeRatesApi
{
    public class ExchangeRates
    {
        public Dictionary<string, decimal> RATES { get; set; }

        public string BASE { get; set; }

        public DateTime? DATE { get; set; }
    }
}
