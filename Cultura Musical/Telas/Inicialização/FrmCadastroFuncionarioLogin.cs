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
            catch (Exception)
            {
                MessageBox.Show("Não deve haver espaços entre um caracter e outro.");
            }
        }
    }
}
