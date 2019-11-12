using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Fornecedores
{
    public partial class FrmConsultarFornecedores : Form
    {
        Business.Business_Fornecedores Bus = new Business.Business_Fornecedores();

        public FrmConsultarFornecedores()
        {
            InitializeComponent();

            this.CarregarGrid();     
        }

        private void CarregarGrid()
        {
            Business.Business_Fornecedores forn = new Business.Business_Fornecedores();
            List<Database.Entity.tb_fornecedor> ok = forn.ListarForn();

            dgvNMFornecedor.DataSource = ok;
        }

        private void txtNFornecedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNFornecedor.Text;

                Business.Business_Fornecedores forne = new Business.Business_Fornecedores();
                List<Database.Entity.tb_fornecedor> ok = forne.ListarNome(nome);
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
            Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void btnHolerite_Click(object sender, EventArgs e)
        {
            Telas.Folha_Pagamento.frmGerarFolhaD tela = new Folha_Pagamento.frmGerarFolhaD();
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

        private void label17_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }

        private void FrmConsultarFornecedores_Load(object sender, EventArgs e)
        {
            //dgvNMFornecedor.BorderStyle = BorderStyle.None;
            //dgvNMFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dgvNMFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dgvNMFornecedor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dgvNMFornecedor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dgvNMFornecedor.BackgroundColor = Color.White;


            //dgvNMFornecedor.EnableHeadersVisualStyles = false;
            //dgvNMFornecedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dgvNMFornecedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dgvNMFornecedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

           


            
        }

        private void dgvNMFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (dgvNMFornecedor.CurrentCell.ColumnIndex == remover.Index)
            {
                var forn = dgvNMFornecedor.CurrentRow.DataBoundItem as
                   Database.Entity.tb_fornecedor;

                if (e.ColumnIndex == 12)
                {
                    this.EditarFornecedor(forn);
                }

                if (e.ColumnIndex == 13)
                {
                    this.ExcluirFornecedor(forn);

                }

            }       

        }

        private void EditarFornecedor(Database.Entity.tb_fornecedor forn)
        {
            Telas.Fornecedores.frmAlterarFornecedor tela = new Fornecedores.frmAlterarFornecedor();
            tela.Show();
            this.Hide();

        }


        private void ExcluirFornecedor(Database.Entity.tb_fornecedor forn)
        {
            DialogResult resposta = MessageBox.Show("Deseja remover o fornecedor?", "Cultura Musical",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Bus.Remover(forn.id_fornecedor);
                this.CarregarGrid();
            }
        }


        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmAdicionarFornecedor tela = new FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmConsultarFornecedores tela = new FrmConsultarFornecedores();
            tela.Show();
            this.Hide();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmCadastroFuncionarioD tela = new Funcionarios.frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmConsultarFuncionarioD tela = new Funcionarios.frmConsultarFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new Planos.frmAdicionarPlano();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Planos.cbo tela = new Planos.cbo();
            tela.Show();
            this.Hide();
        }

        private void cmsProdutos_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void inserirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();

        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmConsultarPedidoD tela = new Produtos.frmConsultarPedidoD();
            tela.Show();
            this.Hide();
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
