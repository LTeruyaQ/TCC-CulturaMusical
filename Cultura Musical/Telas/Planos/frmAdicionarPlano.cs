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
    public partial class frmAdicionarPlano : Form
    {
        Database.Entity.tb_plano plano = new Database.Entity.tb_plano();
        public frmAdicionarPlano()
        {
            InitializeComponent();
            Database.Database_Planos planos = new Database.Database_Planos();
            List<Database.Entity.tb_plano> lista = planos.ListarTodos();

            cbonome.DisplayMember = nameof(plano.nm_plano);
            cbonome.DataSource = lista;


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            plano.nm_plano = txtnome.Text;
            plano.qtd_aula_semana = Convert.ToInt32( nudqtd.Value);
            plano.vl_preco = nudpreço.Value;
            plano.ds_descricao = txtdesc.Text;
            plano.ds_duracao = Convert.ToInt32(txtduração.Text);

            
            Business.Business_Planos bus = new Business.Business_Planos();
            bus.CadastrarPlano(plano);

            MessageBox.Show("Plano cadastrado com sucesso");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbonome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonome.ValueMember = nameof(plano.vl_preco);
            nudalterar.Value= Convert.ToDecimal(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.qtd_aula_semana);
            nud_qtd_alterar.Value = Convert.ToDecimal(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.ds_duracao);
            txtduraçãoalterar.Text = Convert.ToString(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.ds_descricao);
            txtdescalterar.Text = Convert.ToString(cbonome.SelectedValue);
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void button9_Click(object sender, EventArgs e)
        {

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
            Holerite.FrmAddHolerite tela = new Holerite.FrmAddHolerite();
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

        private void btnCRM_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFornecedores_Click_1(object sender, EventArgs e)
        {

        }
    }
}
