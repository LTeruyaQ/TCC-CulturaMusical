using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Planos
{
    public partial class cbo : Form
    {
        Database.Entity.tb_plano plano = new Database.Entity.tb_plano();

        Database.Database_Planos db = new Database.Database_Planos();

        public cbo()
        {
            InitializeComponent();
           


            List<Database.Entity.tb_plano> lista = db.ListarTodos();
            cboplanos.DisplayMember = nameof(plano.nm_plano);
            cboplanos.DataSource = lista;

           

        }
      

        private void cboplanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboplanos.ValueMember = nameof(plano.vl_preco);
            lblvalor0.Text = Convert.ToString(cboplanos.SelectedValue);

            cboplanos.ValueMember = nameof(plano.qtd_aula_semana);
            lblaulas.Text = Convert.ToString(cboplanos.SelectedValue);

            cboplanos.ValueMember = nameof(plano.ds_duracao);
            lblduração.Text = Convert.ToString(cboplanos.SelectedValue);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string nm_cliente = txtnome.Text;
            Database.Database_Cliente cliente = new Database.Database_Cliente();
            int id = cliente.buscarid(nm_cliente);
            cboplanos.ValueMember = nameof(plano.id_plano);
            Database.Entity.tb_venda_plano venda = new Database.Entity.tb_venda_plano();
            venda.id_plano = Convert.ToInt32(cboplanos.SelectedValue);
            venda.id_cliente = id;
            venda.dt_inicio = DateTime.Now.Date;
            venda.dt_fim = dtpfinal.Value;

            db.VendaPlano(venda);

            MessageBox.Show("Venda feita com sucesso.");
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            
            
            
    }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            string nm_cliente = txtnome.Text;
            Business.Business_Cliente bus = new Business.Business_Cliente();
            List<Database.Entity.tb_cliente> cliente = bus.listapornome(nm_cliente);
            dgvlista.DataSource = cliente;
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

        private void bbtAgenda_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new frmAdicionarPlano();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Telas.Planos.cbo tela = new cbo();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmConsultarFornecedores tela = new Fornecedores.FrmConsultarFornecedores();
            tela.Show();
            this.Hide();
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

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void cbo_Load(object sender, EventArgs e)
        {
            dgvlista.BorderStyle = BorderStyle.None;
            dgvlista.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvlista.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvlista.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvlista.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvlista.BackgroundColor = Color.White;

            dgvlista.EnableHeadersVisualStyles = false;
            dgvlista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvlista.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvlista.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }
    }
}
