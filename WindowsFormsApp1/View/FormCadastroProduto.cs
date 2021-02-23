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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição Obrigatória!");
                txtDescricao.Focus();
                return;
            }

            if (txtPreco.Text == "")
            {
                MessageBox.Show("Preço Obrigatório!");
                txtPreco.Focus();
                return;
            }

            //Cadastrando produto
            Model.Produto prod = new Model.Produto()            
            {
                Codigo = txtCodigo.Text,
                Descricao = txtDescricao.Text,
                Preco = Convert.ToDouble(txtPreco.Text)
            };

            FormPrincipal.produtos.Add(prod);
            MessageBox.Show("Produto Cadastrado!");

            listViewProduto.Items.Clear();
            for (int i = 0; i < FormPrincipal.produtos.Count(); i++)
            {
                //Código
                listViewProduto.Items.Add(
                    FormPrincipal.produtos[i].Codigo);
                //Descrição
                listViewProduto.Items[i].SubItems.Add(
                    FormPrincipal.produtos[i].Descricao);
                //Preço
                listViewProduto.Items[i].SubItems.Add(
                    FormPrincipal.produtos[i].Preco.ToString());
            }
            


        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && 
                (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numero e virgula!");
            }
        }
        }
    }
