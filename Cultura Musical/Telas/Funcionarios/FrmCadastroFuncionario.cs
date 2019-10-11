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
            funcionario.telefone = txtTelefone.Text;
            funcionario.cargo = txtCargo.Text;
            funcionario.cpf = txtCEP.Text;
            funcionario.contratacao = dtpContratacao.Value;
            funcionario.email = txtemail.Text;
            funcionario.rg = txtRG.Text;
            funcionario.hr_almoco = TimeSpan.Parse(Convert.ToString(dtpAlmoco.Value));
            funcionario.hr_entrada = TimeSpan.Parse(Convert.ToString(dtpEntrada.Value));
            funcionario.hr_saida = TimeSpan.Parse(Convert.ToString(dtpSaida.Value));

            Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
            colaborador.CadastroFuncionario(funcionario);

            string genero = cboGenero.Text;

            if (genero == "masculino")
            {
                funcionario.genero = true;
            }
            else
            {
                funcionario.genero = false;
            }
        }
    }
}
