using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Folha_Pagamento
{
    public partial class frmGerarFolhaD : Form
    {
        public frmGerarFolhaD()
        {
            InitializeComponent();
        }

        Business.Business_Folha_Pagamento folhaBus = new Business.Business_Folha_Pagamento();
        Business.Business_Financeiro financeiroBus = new Business.Business_Financeiro();

        private void btnprocurar_click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario fon = new Database.Entity.tb_funcionario();
                Database.Entity.tb_financeiro Financeiro = new Database.Entity.tb_financeiro();



                fon.nm_funcionario = txtFuncionario.Text;
                fon.ds_cargo = txtFuncao.Text;
                Database.Entity.tb_funcionario holerites = folhaBus.ConsultarPorFuncionario(fon);



                    Financeiro.ds_fgts = 8;

                   
                if (holerites.vl_salario <= Convert.ToDecimal(1781.81))
                {
                    Financeiro.ds_inss = 8;
                }

                if (holerites.vl_salario >= Convert.ToDecimal(1781.82) && holerites.vl_salario <= Convert.ToDecimal(2919.72))
                {
                    Financeiro.ds_inss = 9;
                }

                if (holerites.vl_salario >= Convert.ToDecimal(2919.73) && holerites.vl_salario <= Convert.ToDecimal (5839.45))
                {
                    Financeiro.ds_inss = 11;
                }

                if (holerites.vl_salario >= Convert.ToDecimal (5839.46))
                {
                    Financeiro.ds_inss = 15;
                }

                if (holerites.vl_salario < Convert.ToDecimal(1903.99)) 
                {
                    Financeiro.ds_irrf = 0;
                }

                if (holerites.vl_salario >= Convert.ToDecimal(1903.99) && holerites.vl_salario <= Convert.ToDecimal (2826.65)) 
                {
                    Financeiro.ds_irrf = Convert.ToDecimal( 7.5);
                }

                if (holerites.vl_salario >= Convert.ToDecimal(2826.66) && holerites.vl_salario <= Convert.ToDecimal(3751.05))
                {
                    Financeiro.ds_irrf = 15;
                }

                if (holerites.vl_salario >= Convert.ToDecimal (3751.06) && holerites.vl_salario <= Convert.ToDecimal (4664.67))
                {
                    Financeiro.ds_irrf = Convert.ToDecimal( 22.5);
                }

                if (holerites.vl_salario >= Convert.ToDecimal(4664.68)) 
                {
                    Financeiro.ds_irrf = Convert.ToDecimal(27.5);
                }

                

                financeiroBus.inserir(Financeiro);





                decimal INSS = Financeiro.ds_inss;
                decimal IRRF = Financeiro.ds_irrf;

                INSS = this.ConvercaoINSS(INSS);
                IRRF = this.ConvercaoIRRF(IRRF);
                
                


                decimal totalprovento = holerites.vl_salario;
                decimal totaldesconto = (holerites.vl_salario = 0.08m) 
                                      + (holerites.vl_salario * INSS) 
                                      + (holerites.vl_salario * IRRF) 
                                      + (holerites.vl_salario * 0.06m) 
                                      + (holerites.vl_salario * 0.08m);

                lblSalarioProvento.Text = Convert.ToString (holerites.vl_salario + holerites.tb_beneficio.ds_gratificacao);
                lblGratificaçãoProvento.Text = Convert.ToString(holerites.tb_beneficio.ds_gratificacao);
                lblTotalDesconto.Text = Convert.ToString(totaldesconto);
                lblTotalProvento.Text = Convert.ToString(totalprovento);
                lblVADesconto.Text = Convert.ToString(holerites.vl_salario * 0.06m);
                lblVTDesconto.Text = Convert.ToString(holerites.vl_salario * 0.08m);

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


        private decimal ConvercaoINSS (decimal INSS )
        {
            if (INSS == 8)
            {
                INSS = 0.08m;
            }

            if (INSS == 9)
            {
                INSS = 0.09m;
            }

            if (INSS == 11)
            {
                INSS = 0.11m;
            }

            if (INSS == 15)
            {
                INSS = 0.15m;
            }

            return INSS;
        }


        private decimal ConvercaoIRRF(decimal IRRF)
        {
            if (IRRF == 7.5m)
            {
                IRRF = 0.075m;
            }

            if (IRRF == 15m)
            {
                IRRF = 0.15m;
            }

            if (IRRF == 22.5m)
            {
                IRRF = 0.225m;
            }

            if (IRRF == 27.5m)
            {
                IRRF = 0.275m;
            }

            return IRRF;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Business.ImprimirTela p = new Business.ImprimirTela();
            //p.Imprimir(this, panel5);
        }

        private void label3_Click(object sender, EventArgs e)
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
    }
}
