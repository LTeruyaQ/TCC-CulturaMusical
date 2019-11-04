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
    public partial class frmCadastroFuncionarioD : Form
    {
        public frmCadastroFuncionarioD()
        {
            InitializeComponent();
        }

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

                funcionario.nm_funcionario = txtNome.Text;
                funcionario.vl_salario = Convert.ToDecimal(nudSalario.Value);
                funcionario.ds_telefone = txtTelefone.Text;
                funcionario.ds_cargo = txtCargo.Text;
                funcionario.ds_cpf = txtMascara.Text;
                funcionario.ds_cep = txtCEP.Text;
                funcionario.dt_contratacao = dtpContratacao.Value;
                funcionario.ds_email = txtEmail.Text;
                funcionario.ds_rg = txtRG.Text;
                funcionario.ds_bairro = txtBairro.Text;
                funcionario.ds_estado = txtEstado.Text;
                funcionario.ds_rua = txtRua.Text;              

             
                string genero = cboGenero.Text;

                if (genero == "masculino")
                {
                    funcionario.ds_genero = "M";
                }
                else
                {
                    funcionario.ds_genero = "F";
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
            txtEstado.Text = resp.localidade;
            txtBairro.Text = resp.bairro;
        }

       
    }
}

