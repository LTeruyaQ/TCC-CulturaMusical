using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas
{
    public partial class dtpNascimento : Form
    {
        public dtpNascimento()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
            funcionario.nm_funcionario = txtNome.Text;
            funcionario.vl_salario = Convert.ToDecimal(txtSalario.Text);
            funcionario.ds_telefone = txtTelefone.Text;
            funcionario.ds_cargo = txtCargo.Text;
            funcionario.ds_cpf = txtCEP.Text;
            funcionario.dt_contratacao = dtpContratacao.Value;
            funcionario.ds_email = txtemail.Text;
            funcionario.ds_rg = txtRG.Text;
            Database.Entity.tb_jornada jor = new Database.Entity.tb_jornada();           
            jor.hr_entrada = TimeSpan.Parse(Convert.ToString(dtpEntrada.Value));
            jor.hr_saida = TimeSpan.Parse(Convert.ToString(dtpSaida.Value));

            Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
            colaborador.CadastroFuncionario(funcionario);

            string genero = cboGenero.Text;

            if (genero == "masculino")
            {
                funcionario.ds_genero = true;
            }
            else
            {
                funcionario.ds_genero = false;
            }
        }
    }
}
