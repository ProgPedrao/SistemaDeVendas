using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaVendas.Model;

namespace SistemaVendas.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Variável utilizada em todo o sistema
        static public List<Produto> produtos = new List<Model.Produto>();
        static public Financeiro financeiro;
        static public List<Venda> vendas = new List<Venda>();
        static public List<Destinatario> destinatarios = new List<Destinatario>();
        

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre o form de cadastro de produto
            using(FormCadastroProduto produto = new FormCadastroProduto())            
                produto.ShowDialog();

        }

        private void CadastrarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormFinanceiro CadastroFinanceiro = new FormFinanceiro())
                CadastroFinanceiro.ShowDialog();
        }

        private void ConsultaSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {   if (financeiro != null)
                MessageBox.Show(Convert.ToString(financeiro.Saldo));
            else
                MessageBox.Show("Nenhuma conta Cadastrada");
        
        }

        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVendas telavendas = new FormVendas())
                telavendas.ShowDialog();
        }

        private void DestinatarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastroDest CadastrarCliente = new FormCadastroDest())
                CadastrarCliente.ShowDialog();
        }
    }
}
