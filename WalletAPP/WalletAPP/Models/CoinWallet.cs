using System.Collections.Generic;

namespace WalletAPP.Models
{
    public class CoinWallet
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Coin Coin { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
