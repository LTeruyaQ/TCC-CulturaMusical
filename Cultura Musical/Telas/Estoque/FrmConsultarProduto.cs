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
    public partial class FrmConsultarProduto : Form
    {
        public FrmConsultarProduto()
        {
            InitializeComponent();

            Business.Business_Estoque pedido = new Business.Business_Estoque();
            List<Database.Entity.tb_produto> con = pedido.ListarTudo();

            dgvListar.DataSource = con;

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;

                Business.Business_Estoque top = new Business.Business_Estoque();
                List<Database.Entity.tb_produto> con = top.ListarProduto(produto);

                dgvListar.DataSource = con;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.");
            }
        }
    }
}
