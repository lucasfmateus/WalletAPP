using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class Notification
    {
        public string Id { get; set; }
        public string IconUri { get; set; }
        public string Title { get; set; }
        public string Resume { get; set; }
        public string Content { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
