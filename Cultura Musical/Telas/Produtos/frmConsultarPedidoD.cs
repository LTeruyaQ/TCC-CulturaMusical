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
    public partial class frmConsultarPedidoD : Form
    {
        public frmConsultarPedidoD()
        {
            InitializeComponent();

            Database.Entity.tb_produto pedido = new Database.Entity.tb_produto();

            Business.Business_Pedidos pedidoo = new Business.Business_Pedidos();


            List<Database.Entity.tb_produto> con = pedidoo.ListarTudo(pedido);

            dgvListar_Pedidos.DataSource = con;
        }
        private void txtProduto_TextChanged(object sender, EventArgs e)
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

        private void dtpCompra_ValueChanged(object sender, EventArgs e)
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

  

        private void frmConsultarPedidoD_Load(object sender, EventArgs e)
        {

       


            
                dgvListar_Pedidos.BorderStyle = BorderStyle.None;
            dgvListar_Pedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvListar_Pedidos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListar_Pedidos.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListar_Pedidos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvListar_Pedidos.BackgroundColor = Color.White;


            dgvListar_Pedidos.EnableHeadersVisualStyles = false;
            dgvListar_Pedidos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListar_Pedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvListar_Pedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }
    }
}
