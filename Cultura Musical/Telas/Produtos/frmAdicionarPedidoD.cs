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
    public partial class frmAdicionarPedidoD : Form
    {
        public frmAdicionarPedidoD()
        {
            InitializeComponent();
        }

        private void dtpCompra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmAdicionarPedidoD_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_produto pedido = new Database.Entity.tb_produto();

                pedido.nm_produto = txtProduto.Text;
                pedido.qtd_produto = Convert.ToInt32(nudQtd.Value);
                pedido.vl_preco = Convert.ToInt32(nudPreco.Value);

                Database.Entity.tb_compra compra = new Database.Entity.tb_compra();
                compra.dt_compra = dtpCompra.Value;
                compra.dt_entrega = dtpEntrega.Value;

                Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();
                cboFornecedor.DisplayMember = forn.nm_fornecedor;

                cboFornecedor.DataSource = forn;

                Business.Business_Pedidos top = new Business.Business_Pedidos();

                top.cadastrar(compra, pedido);

                MessageBox.Show("Produto adicionado com sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se tods os campos foram preenchidos.");
            }
        }
    }
}
