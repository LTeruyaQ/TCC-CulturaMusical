using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Folha_de_Pagamento
{
    public partial class Inserir : Form
    {
        public Inserir()
        {
            InitializeComponent();
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string func = txtFuncionario.Text;

            Database.Entity.tb_funcionario fon = new Database.Entity.tb_funcionario();


            fon.vl_salario = Convert.ToDecimal(lblSalario.Text);

            Business.Business_Folha_Pagamento folha = new Business.Business_Folha_Pagamento();
            folha.ExtrairSalario(func, fon);

        }
    }
}
