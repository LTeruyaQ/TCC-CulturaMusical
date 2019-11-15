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

            //Database.Entity.tb_produto pedido = new Database.Entity.tb_produto();

            //Business.Business_Pedidos pedidoo = new Business.Business_Pedidos();


            //List<Database.Entity.tb_produto> con = pedidoo.ListarTudo(pedido);

            //dgvListar_Pedidos.DataSource = con;
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

        private void lblFechar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente deseja fechar o sistema ?", "Cultura Musical",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            Agenda.FrmConsultarAgenda tela = new Agenda.FrmConsultarAgenda();
            tela.Show();
            this.Hide();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            Funcionarios.frmCadastroFuncionarioD tela = new Funcionarios.frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void btnCRM_Click(object sender, EventArgs e)
        {
            CRM.FrmAdicionarCliente tela = new CRM.FrmAdicionarCliente();
            tela.Show();
            this.Hide();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
         
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            Telas.Folha_Pagamento.frmGerarFolhaD tela = new Telas.Folha_Pagamento.frmGerarFolhaD();
            tela.Show();
            this.Hide();
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            Logistica.Fluxo_de_Caixa.frmFluxoD tela = new Logistica.Fluxo_de_Caixa.frmFluxoD();
            tela.Show();
            this.Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Planos.cbo tela = new Planos.cbo();
            tela.Show();
            this.Hide();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmCadastroFuncionarioD tela = new Funcionarios.frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmConsultarFuncionarioD tela = new Funcionarios.frmConsultarFuncionarioD();
            tela.Show();
            this.Hide();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Telas.Funcionarios.frmAlterarColaborador tela = new Funcionarios.frmAlterarColaborador();
            //tela.Show();
            //this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmConsultarFornecedores tela = new Fornecedores.FrmConsultarFornecedores();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmConsultarPedidoD tela = new frmConsultarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Telas.Produtos.FrmAlterarProduto tela = new FrmAlterarProduto();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new Planos.frmAdicionarPlano();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Telas.Planos.cbo tela = new Planos.cbo();
            tela.Show();
            this.Hide();
        
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }
    }
}
