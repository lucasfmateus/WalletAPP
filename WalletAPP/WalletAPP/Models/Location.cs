using System;
using System.Collections.Generic;
using System.Text;

namespace WalletAPP.Models
{
    public class Location
    {
        public string Id { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }

    }
}
