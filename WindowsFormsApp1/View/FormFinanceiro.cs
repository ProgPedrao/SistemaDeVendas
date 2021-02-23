using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVendas.Model;

namespace SistemaVendas.View
{
    public partial class FormFinanceiro : Form
    {
        public FormFinanceiro()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormPrincipal.financeiro = new Financeiro
            {
               NumeroConta = Convert.ToInt32(txtCodigo.Text),
               Saldo = Convert.ToDouble(txtSaldo.Text)              
            };
            MessageBox.Show("Sucesso");
            this.Close();
        }
    }
}
