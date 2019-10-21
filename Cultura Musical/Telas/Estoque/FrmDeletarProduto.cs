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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            string produto = cboProduto.Text;

            Business.Business_Estoque prod = new Business.Business_Estoque();
            prod.Remover(produto);

            MessageBox.Show("Excluído com sucesso!");
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
