using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.View
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        Model.Venda Venda = new Model.Venda();
        List<Model.VendaItem> Itens = new List<Model.VendaItem>();
        Model.VendaItem Item = new Model.VendaItem();

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtTotal.Text == "0")
            {
                MessageBox.Show("Nenhum Produto informado");
                txtProdutoCodigo.Focus();
                return;
            }

            Venda.Numero = Convert.ToInt32(txtNumero.Text);
            Venda.Serie = Convert.ToInt32(txtSerie.Text);
            Venda.DataEmissao = dtEmissao.Value;
            Venda.Produtos = Itens;
            Venda.SubTotal = Convert.ToDouble(txtSubTotal.Text);
            Venda.Desconto = Convert.ToDouble(txtDesconto.Text);
            Venda.Total = Convert.ToDouble(txtTotal.Text);

            Controller.Movimentacoes.EfetuarVendas(Venda);
            MessageBox.Show("Venda realizada com sucesso");

            Limpar();



        }

        private void BtnAddProduto_Click(object sender, EventArgs e)
        {

            if (txtProdutoCodigo.Text == "")
            {
                MessageBox.Show("Codigo do Produto não informado");
                txtProdutoCodigo.Focus();
                return;
            }

            if (txtProdutoQtd.Text == "")
            {
                MessageBox.Show("Quantidade de Produtos não informado");
                txtProdutoQtd.Focus();
                return;
            }

            Item.Codigo = txtProdutoCodigo.Text;
            Item.Preco = Convert.ToDouble(txtProdutoPreco.Text);
            Item.totalItem = Item.qtdItem * Item.Preco;
            Itens.Add(Item);
            Controller.Movimentacoes.CarregarListView(ref listView1, Itens);
            Totalizar();
        }

        private void TxtProdutoCodigo_Leave(object sender, EventArgs e)
        {
            foreach (Model.Produto auxItem in FormPrincipal.produtos)
            {
                if (txtProdutoCodigo.Text == auxItem.Codigo)
                {
                    Item.Descricao = auxItem.Descricao;
                    txtProdutoPreco.Text = auxItem.Preco.ToString();
                    break;
                }
            }
        }

        private void TxtProdutoQtd_Leave(object sender, EventArgs e)
        {
            if (txtProdutoQtd.Text == "" || txtProdutoQtd.Text == "0")
            {
                txtProdutoQtd.Text = "1";
            }
            Item.qtdItem = Convert.ToDouble(txtProdutoQtd.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Totalizar()
        {
            double SubTotal = 0;
            foreach (Model.VendaItem auxItem in Itens)
            {
                SubTotal += auxItem.totalItem;
            }
            txtSubTotal.Text = SubTotal.ToString();
            txtTotal.Text = (SubTotal - Convert.ToDouble(txtDesconto.Text)).ToString();
        }
        
        private void Limpar()
        {
            txtNumero.Text = "";
            txtSerie.Text = "";
            txtDestCodigo.Text = "";
            txtDestCpf.Text = "";
            txtDestNome.Text = "";
            txtDesconto.Text = "";
            txtProdutoCodigo.Text = "";
            txtProdutoPreco.Text = "";
            txtProdutoQtd.Text = "";
            txtSubTotal.Text = "0";
            txtTotal.Text = "0";
            txtDesconto.Text = "0";
            dtEmissao.Value = DateTime.Now;
            Venda = null;
            Itens.Clear();
            Item = null;
            listView1.Items.Clear();
        }

        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            Totalizar();
        }

        private void TxtDestCodigo_Leave(object sender, EventArgs e)
        {
            foreach (Model.Destinatario auxDest in FormPrincipal.destinatarios)
            {
                if (txtDestCodigo.Text == auxDest.Codigo.ToString())
                {
                    txtDestNome.Text = auxDest.Nome;
                    txtDestCpf.Text = auxDest.Cpf.ToString();
                    break;
                }
            }
        }
    }
}
