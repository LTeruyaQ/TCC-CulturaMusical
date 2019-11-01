using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Inicialização
{
    public partial class FrmCadastroFuncionarioLogin : Form
    {
        public FrmCadastroFuncionarioLogin()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_login cadastro = new Database.Entity.tb_login();
                cadastro.nm_usuario = txtUsuario.Text;
                cadastro.sen_usuario = txtSenha.Text;
                string conf = txtconfirmar.Text;
                Business.Business_Inicialização bus = new Business.Business_Inicialização();
                bus.Cadastro(cadastro, conf);

                MessageBox.Show("Funcionário cadastrado com sucesso!");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
