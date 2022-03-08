using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string PartnerName { get; set; }
        public string NF { get; set; }
        public decimal Value { get; set; }
        public int PointsRedeemed { get; set; }
        public TransactionType TransactionType { get; set; }
    }

    public enum TransactionType
    {
        Program, 
        Currency
    }
}
