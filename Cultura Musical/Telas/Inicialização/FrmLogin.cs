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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Business.Business_Inicialização Bus = new Business.Business_Inicialização();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ///aqui invocaria a tela de permição///
        }

        private void btnConfirmar_Login_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nome  = txtUsuario.Text;
                string Senha = txtSenha.Text;

                Bus.login(nome, Senha);


                Telas.Inicialização.frmSplash tela = new Inicialização.frmSplash();
                tela.Show();
                this.Hide();
            }

            catch (ArgumentException ex)
            {
                lblaviso.Text = ex.Message;
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Tente mais tarde.");
            }

            

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Login_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar_Login.BackColor = Color.SkyBlue;
            btnConfirmar_Login.ForeColor = Color.Black;


        }

        private void btnConfirmar_Login_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar_Login.BackColor = Color.SkyBlue;
            btnConfirmar_Login.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {
           
                this.WindowState = FormWindowState.Minimized;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente deseja fechar o sistema ?", "Cultura Musical",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
