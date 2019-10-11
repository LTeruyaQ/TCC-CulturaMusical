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
    public partial class FrmAdicionarProduto : Form
    {
        public FrmAdicionarProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Database.Entity.tb_produto_compra pedido  = new Database.Entity.tb_produto_compra();
            pedido.nm_produto = txtProduto.Text;
            pedido.quantidade = Convert.ToInt32(nudQtd.Value);
            pedido.preco = Convert.ToInt32(nudPreco.Value);
            Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();
            pedido.tb_fornecedor.nm_fornecedor = cboFornecedor.Text;
            

            Business.Business_Pedidos top = new Business.Business_Pedidos();
            top.AdicionarPedido(pedido,forn);

            MessageBox.Show("Salvo com sucesso");
        }
    }
}
