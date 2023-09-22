using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoMatioli
{
    public partial class frmCadastroProduto : Form
    {
        public frmCadastroProduto()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            txtCodigo.Text = "";
            txtNome.Text = "";
            listBoxCategoria.ClearSelected();
            listBoxFornecedor.ClearSelected();
            listBoxCategoria.SelectedIndex = -1;
            listBoxFornecedor.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("É OBRIGATÓRIO o preenchimento do campo CÓDIGO", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("É OBRIGATÓRIO o preenchimento do campo NOME", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if(listBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxCategoria.Focus();
                return;
            }
            if (listBoxFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxFornecedor.Focus();
                return;
            }

            groupBox1.Enabled = false;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            groupBox1.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
