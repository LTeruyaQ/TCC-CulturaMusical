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
    public partial class FrmAdicionarFornecedor : Form
    {
        public FrmAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();

                forn.nm_fornecedor = txtRSocial.Text;
                forn.inscicao_estadual = txtInscricao.Text;
                forn.tell_contato = mskTel1.Text;
                forn.tell_contato2 = mskTel2.Text;
                forn.ds_email = txtEmail.Text;
                forn.cep = mskCEP.Text;
                forn.rua = txtRua.Text;
                forn.bairro = txtBairro.Text;
                forn.cidade = txtCidade.Text;
                forn.ds_cnpj = mstCNPJ.Text;

                Business.Business_Fornecedores forne = new Business.Business_Fornecedores();
                forne.AddForn(forn);

                MessageBox.Show("Fornecedor adicionado com sucesso.");
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

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            btnInserir.BackColor = Color.LightGray;
        }

        private void btnInserir_MouseLeave(object sender, EventArgs e)
        {
            btnInserir.BackColor = Color.SkyBlue;
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

        private void mskCEP_Leave(object sender, EventArgs e)
        {

            API_s.Correio__API api = new API_s.Correio__API();
            dynamic resp = api.Buscar(mskCEP.Text);

            txtRua.Text = resp.logradouro;
            txtCidade.Text = resp.localidade;
            txtBairro.Text = resp.bairro;
        }
    }
}
