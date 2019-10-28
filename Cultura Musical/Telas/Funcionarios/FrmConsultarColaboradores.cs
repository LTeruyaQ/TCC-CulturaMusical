using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Funcionario
{
    public partial class FrmConsultarFuncionarios : Form
    {
        public FrmConsultarFuncionarios()
        {
            InitializeComponent();
        }

        Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();

        //por que a Business tá instanciada solta aqui? ->Gouget 

        private void txtNomeFuncionário_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeFuncionário.Text;

                Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
                List<Database.Entity.tb_funcionario> func = colaborador.ListarPorNome(nome);

                dgvConsultaFuncionario.DataSource = func;

                //não precisa dar MessageBox na tela de consultar, eu acho. ->Gouget
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

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cargo = txtCargo.Text;

                Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
                List<Database.Entity.tb_funcionario> func = colaborador.ListarPorCargo(cargo);

                dgvConsultaFuncionario.DataSource = func;
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
    }
}
