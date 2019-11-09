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
        public FrmConsultarFornecedores()
        {
            InitializeComponent();

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
            dgvNMFornecedor.BorderStyle = BorderStyle.None;
            dgvNMFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvNMFornecedor.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNMFornecedor.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvNMFornecedor.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvNMFornecedor.BackgroundColor = Color.White;


            dgvNMFornecedor.EnableHeadersVisualStyles = false;
            dgvNMFornecedor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNMFornecedor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvNMFornecedor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            int n = 0;

            for (int i = 0; i < 12; i++)
            {
                n = dgvNMFornecedor.Rows.Add();
                dgvNMFornecedor.Rows[n].Cells[0].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[1].Value = "------------------ ";
                dgvNMFornecedor.Rows[n].Cells[2].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[3].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[4].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[5].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[6].Value = "------------------ ";
                dgvNMFornecedor.Rows[n].Cells[7].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[8].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[9].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[10].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[11].Value = "------------------ ";
            

                n = dgvNMFornecedor.Rows.Add();
                dgvNMFornecedor.Rows[n].Cells[0].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[1].Value = "------------------ ";
                dgvNMFornecedor.Rows[n].Cells[2].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[3].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[4].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[5].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[6].Value = "------------------ ";
                dgvNMFornecedor.Rows[n].Cells[7].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[8].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[9].Value = "-------------------";
                dgvNMFornecedor.Rows[n].Cells[10].Value = "------------------";
                dgvNMFornecedor.Rows[n].Cells[11].Value = "------------------ ";
            }
      


            
        }

        private void dgvNMFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNMFornecedor.CurrentCell.ColumnIndex == remover.Index)
            {
                Database.Entity.tb_funcionario cul = dgvNMFornecedor.CurrentRow.DataBoundItem as
                    Database.Entity.tb_funcionario;

                var id = cul.id_funcionario;

                Business.Business_Fornecedores business_Fornecedores = new Business.Business_Fornecedores();
                business_Fornecedores.Remover(id);




            }
            else
            {
                return;
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
    }
}
