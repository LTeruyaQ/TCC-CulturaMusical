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

            Business.Business_Produtos pro = new Business.Business_Produtos();
            List<Database.Entity.tb_produto_compra> produto = pro.ListarProduto();

            dgvListar.DataSource = produto;
    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultarProduto_Load(object sender, EventArgs e)
        {
         
        }
    }
}
