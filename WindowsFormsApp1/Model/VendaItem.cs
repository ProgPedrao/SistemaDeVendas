using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendas.Model
{
    public class VendaItem : Produto
    {
        public double qtdItem { get; set; }
        public double totalItem { get; set; }
    }
}
