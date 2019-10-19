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

            string produto = txtProduto.Text;

            Business.Business_Produtos pedido = new Business.Business_Produtos();
            List<Database.Entity.tb_produto> con = pedido.ListarPorProduto(produto);

            dgvListar.DataSource = con;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultarProduto_Load(object sender, EventArgs e)
        {
           

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
