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

            string produto = txtProduto.Text;
            DateTime data = dtpCompra.Value;
            

            Business.Business_Pedidos pedido = new Business.Business_Pedidos();
            List<Database.Entity.tb_produto> con = pedido.ListarPedido(produto,data);

            dataGridView1.DataSource = con;

        }

        
        private void FrmConsultarProdutos_Load(object sender, EventArgs e)
        {

        }

        public void txtProduto_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
