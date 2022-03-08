using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class AccountFunds
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }
    }
}
