using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Logistica.Fluxo_de_Caixa
{
    public partial class frmFluxoD : Form
    {

        Business.Business_Logistica bus = new Business.Business_Logistica();
        public frmFluxoD()
        {
            InitializeComponent();

            try
            {
                List<Database.Entity.fluxo_de_caixa> lista = bus.FluxodeCaixa();

                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }



        private void cbomes_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmFluxoD_Load(object sender, EventArgs e)
        {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dateTimePicker1.Value;

                List<Database.Entity.fluxo_de_caixa> lista = bus.ConsultarPorData(data);

                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void csmColaboradores_Opening(object sender, CancelEventArgs e)
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

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmAdicionarPedidoD tela = new Produtos.frmAdicionarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Telas.Produtos.frmConsultarPedidoD tela = new Produtos.frmConsultarPedidoD();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new Planos.frmAdicionarPlano();
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
