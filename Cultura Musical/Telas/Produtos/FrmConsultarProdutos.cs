using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Pedidos
{
    public partial class FrmConsultarProdutos : Form
    {
        public FrmConsultarProdutos()
        {
            InitializeComponent();

            Database.Entity.tb_produto pedido = new Database.Entity.tb_produto();

            Business.Business_Pedidos pedidoo = new Business.Business_Pedidos();

           
            List<Database.Entity.tb_produto> con = pedidoo.ListarTudo(pedido);

            dgvListar_Pedidos.DataSource = con;
        }

        public void txtProduto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string produto = txtProduto.Text;

                Business.Business_Pedidos pedido = new Business.Business_Pedidos();
                List<Database.Entity.tb_produto> con = pedido.ListarProduto(produto);

                dgvListar_Pedidos.DataSource = con;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Oorreu um erro. Tente mais tarde.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dtpCompra.Value;

                Business.Business_Pedidos pedido = new Business.Business_Pedidos();
                List<Database.Entity.tb_compra> con = pedido.ListarData(data);

                dgvListar_Pedidos.DataSource = con;
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception)
            {
                MessageBox.Show("Oorreu um erro. Tente mais tarde.");
            }  
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListar_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
