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

        private void txtNomeFuncionário_TextChanged(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
            funcionario.nm_funcionario = txtNomeFuncionário.Text;

            Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
            colaborador.Consultar(funcionario);

            dgvConsultaFuncionario.DataSource = funcionario;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario funcionario = new Database.Entity.tb_funcionario();
            funcionario.cargo = txtCargo.Text;

            Business.Business_Funcionarios colaborador = new Business.Business_Funcionarios();
            colaborador.Consultar(funcionario);

            dgvConsultaFuncionario.DataSource = funcionario;
        }

        private void FrmConsultarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsultaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
