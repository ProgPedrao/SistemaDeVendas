using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVendas.Model;
using SistemaVendas.View;
using System.Windows.Forms;

namespace SistemaVendas.Controller
{
    public static class Movimentacoes
    {
        public static bool EfetuarVendas(Venda venda)
        {
            FormPrincipal.vendas.Add(venda);
            return true;

        }

        public static void CarregarListView(ref ListView pListView, List<VendaItem> pLista)
        {
            pListView.Items.Clear();
            for (int i = 0; i < pLista.Count; i++)
            {
                pListView.Items.Add(pLista[i].Codigo);
                pListView.Items[i].SubItems.Add(pLista[i].Descricao);
                pListView.Items[i].SubItems.Add(pLista[i].Preco.ToString());
                pListView.Items[i].SubItems.Add(pLista[i].qtdItem.ToString());
                pListView.Items[i].SubItems.Add(pLista[i].totalItem.ToString());
            }
        }

    }
}
