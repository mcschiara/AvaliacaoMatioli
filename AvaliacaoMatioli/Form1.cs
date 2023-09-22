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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opção não implementada!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Confirma saída?", "Aviso do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
                Application.Exit();
            else if (yesno == DialogResult.No)
            {

            }
                

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor(es):\n- Maria Clara Chiara\n- Lorenza Vitória", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto produto = new frmCadastroProduto();
            produto.MdiParent = this;
            produto.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
