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
    public partial class FormCadastroDest : Form
    {
        public FormCadastroDest()
        {
            InitializeComponent();
        }

        Model.Destinatario destinatario;

        private void BtnAddCliente_Click(object sender, EventArgs e)
        {

            destinatario = new Model.Destinatario();
            destinatario.Codigo = Convert.ToInt16(txtCodigo.Text);
            destinatario.Nome = txtNome.Text;
            destinatario.Cpf = txtCPF.Text;

            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtCodigo.Focus();

            FormPrincipal.destinatarios.Add(destinatario);
            CarregarListView();
        }

        private void CarregarListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < FormPrincipal.destinatarios.Count; i++)
            {
                listView1.Items.Add(FormPrincipal.destinatarios[i].Codigo.ToString());
                listView1.Items[i].SubItems.Add(FormPrincipal.destinatarios[i].Nome);
                listView1.Items[i].SubItems.Add(FormPrincipal.destinatarios[i].Cpf);
                 }
            
        }

        private void FormCadastroDest_Load(object sender, EventArgs e)
        {
            CarregarListView();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCPF.Focus();
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnAddCliente_Click( sender, e);
            }
        }

    }
}
