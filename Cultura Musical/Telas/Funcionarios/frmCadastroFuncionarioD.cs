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

        Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
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
               

                if (rdnCNPJ.Checked == true)
                {
                    txtMascara.Mask = "000.000.000 / 0000 - 00";
                    rdnCPF.Checked = false;
                }

                else if (rdnCPF.Checked == true)
                {
                    txtMascara.Mask = "000.000.000-00";
                    rdnCNPJ.Checked = false;
                }

                string genero = cboGenero.Text;

                if (genero == "masculino")
                {
                    funcionario.ds_genero = "M";
                }
                else
                {
                    funcionario.ds_genero = "F";
                }

                colaborador.CadastroFuncionario(funcionario);

                MessageBox.Show("Funcionário cadastrado com sucesso.");
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

