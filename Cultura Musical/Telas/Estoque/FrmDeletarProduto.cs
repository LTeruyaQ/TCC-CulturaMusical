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

            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.");
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
