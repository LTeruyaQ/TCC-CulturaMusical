using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Funcionarios
{
    public partial class frmCadastroFuncionarioD : Form
    {
        public frmCadastroFuncionarioD()
        {
            InitializeComponent();
        }

        string caminho;

        Business.Business_Funcionarios colaboradorBus = new Business.Business_Funcionarios();
        Business.Business_Jornada JornadaBus = new Business.Business_Jornada();
        Business.Business_Beneficio BeneficioBus = new Business.Business_Beneficio();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
                Database.Entity.tb_jornada Jornada = new Database.Entity.tb_jornada();
                Database.Entity.tb_beneficio Beneficios = new Database.Entity.tb_beneficio();

                Beneficios.ds_gratificacao = 0;
                Beneficios.ds_va = 6;
                Beneficios.ds_vt = 8;
                Beneficios.ds_convenio = 0;
                BeneficioBus.InserirBeneficio(Beneficios);

                
                funcionario.nm_funcionario = txtNome.Text;
                funcionario.dt_nascimento = dtpNascimento.Value.Date;
                funcionario.dt_contratacao = dtpContratacao.Value.Date;
                funcionario.vl_salario = Convert.ToDecimal(nudSalario.Value);
                funcionario.ds_telefone = txtTelefone.Text;
                funcionario.ds_email = txtEmail.Text;
                funcionario.ds_rg = txtRG.Text;
                funcionario.ds_cpf = txtMascara.Text;
                funcionario.ds_cep = txtCEP.Text;
                funcionario.ds_cargo = txtCargo.Text;
                funcionario.ds_rua = txtRua.Text;
                funcionario.ds_estado = txtEstado.Text;
                funcionario.ds_cidade = txtCidade.Text;
                funcionario.ds_complemento = txtComplemento.Text;
                funcionario.ds_bairro = txtBairro.Text;
                funcionario.id_beneficio = Beneficios.id_beneficio;               
                funcionario.nmr_funcionario = Convert.ToInt32(nudNumero.Value);
                
                

                FileStream fs = new FileStream(caminho,FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                byte[] image = br.ReadBytes((int)fs.Length);

                funcionario.ft_funcionario = image;
             
                string genero = cboGenero.Text;

                if (genero == "masculino")
                {
                    funcionario.ds_genero = "m";
                }
                else
                {
                    funcionario.ds_genero = "f";
                }

                colaboradorBus.CadastroFuncionario(funcionario);
                Database.Entity.tb_funcionario Func = colaboradorBus.BuscarFuncionario(funcionario);

                Jornada.hr_entrada = dtpEntrada.Value.TimeOfDay;
                Jornada.hr_intervalo = dtpAlmoco.Value.TimeOfDay;
                Jornada.hr_volta_intervalo = dtpRetorno.Value.TimeOfDay;
                Jornada.hr_saida = dtpSaida.Value.TimeOfDay;
                Jornada.id_funcionario = Func.id_funcionario;

                JornadaBus.InserirJornada(Jornada);

                MessageBox.Show("Funcionário cadastrado com sucesso.");
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            API_s.Correio__API api = new API_s.Correio__API();
            dynamic resp = api.Buscar(txtCEP.Text);

            txtRua.Text = resp.logradouro;
            txtCidade.Text = resp.localidade;
            txtBairro.Text = resp.bairro;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
      
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {

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

        private void cmsAgenda_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmAgenda TELA = new FrmAgenda();
            TELA.Show();
            this.Hide();
               
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "JPG Files(*.jpg)| * .jpg | PNG Files (* .png) | *.png | AllFiles(*.*) | *.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string foto = file.FileName.ToString();
                picFoto.ImageLocation = foto;
                

                caminho = foto;
            }
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmAdicionarFornecedor tela = new Fornecedores.FrmAdicionarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmCadastroFuncionarioD tela = new frmCadastroFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Funcionarios.frmConsultarFuncionarioD tela = new frmConsultarFuncionarioD();
            tela.Show();
            this.Hide();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Fornecedores.FrmConsultarFornecedores tela = new Fornecedores.FrmConsultarFornecedores();
            tela.Show();
            this.Hide();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Planos.frmAdicionarPlano tela = new Planos.frmAdicionarPlano();
            tela.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Telas.Planos.cbo tela = new Planos.cbo();
        }

        private void lblFechar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente deseja fechar o sistema ?", "Cultura Musical",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

