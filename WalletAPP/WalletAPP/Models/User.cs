using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public bool Verified { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Fund Funds { get; set; }
        public Location Location { get; set; }
        public List<CoinWallet> Wallets { get; set; }
    }
}
