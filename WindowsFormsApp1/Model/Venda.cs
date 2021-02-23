using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Model
{
    public class Venda
    {
        public int Numero { get; set; }
        public int Serie { get; set; }
        public DateTime DataEmissao { get; set; }
        public List<VendaItem> Produtos { get; set; }
        public double SubTotal { get; set; }
        public double Desconto { get; set; }
        public double Total { get; set; }
    }
}
