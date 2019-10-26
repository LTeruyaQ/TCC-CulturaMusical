using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Produtos
{
    public partial class FrmDeletarProduto : Form
    {
        public FrmDeletarProduto()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            try
            {
                string produto = cboProduto.Text;

                Business.Business_Pedidos prod = new Business.Business_Pedidos();
                prod.Remover(produto);

                MessageBox.Show("Excluído com sucesso!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível excluir o item, por favor verifique o erro");
            }
        }

        private void btnNão_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            gbCertezas.Visible = true;
        }
    }
}
