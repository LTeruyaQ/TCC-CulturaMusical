using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Funcionarios
{
    public partial class frmConsultarFuncionarioD : Form
    {
        public frmConsultarFuncionarioD()
        {
            InitializeComponent();
        }
        Business.Business_Funcionarios Bus = new Business.Business_Funcionarios();
        private void frmConsultarFuncionarioD_Load(object sender, EventArgs e)
        {
            int n = 0;

            for (int i = 0; i < 5; i++)
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";
            }

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
        

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == Alterar.Index)
            {
                Database.Entity.tb_funcionario cul = dataGridView1.CurrentRow.DataBoundItem as
                    Database.Entity.tb_funcionario;

                var id = cul.id_beneficio;

                Telas.Funcionarios.frmCadastroFuncionarioD tela = new frmCadastroFuncionarioD();

                
            }
            else
            {
                return;
            }
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
            Agenda.FrmAlterarAgenda tela = new Agenda.FrmAlterarAgenda();
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;

            List<Database.Entity.tb_funcionario> funcionario = Bus.ListarPorCargoENome(nome, cargo);

            dataGridView1.DataSource = funcionario;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
