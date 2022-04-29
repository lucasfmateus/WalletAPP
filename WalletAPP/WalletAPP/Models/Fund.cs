using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class Fund
    {
        public decimal Balance { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int DecimalPlaces { get; set; }
    }
}
