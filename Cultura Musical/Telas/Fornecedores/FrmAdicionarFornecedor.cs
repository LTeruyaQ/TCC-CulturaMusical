using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Fornecedores
{
    public partial class FrmAdicionarFornecedor : Form
    {
        public FrmAdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();

                forn.nm_fornecedor = txtRSocial.Text;
                forn.inscicao_estadual = txtInscricao.Text;
                forn.tell_contato = mskTel1.Text;
                forn.tell_contato2 = mskTel2.Text;
                forn.ds_email = txtEmail.Text;
                forn.cep = txtCEP.Text;
                forn.rua = txtRua.Text;
                forn.bairro = txtBairro.Text;
                forn.cidade = txtCidade.Text;
                forn.estado = txtEstado.Text;
                forn.ds_cnpj = txtCNPJ.Text;

                Business.Business_Fornecedores forne = new Business.Business_Fornecedores();
                forne.AddForn(forn);

                MessageBox.Show("Fornecedor adicionado com sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os campos foram preenchidos corretamente");
            }
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            btnInserir.BackColor = Color.LightGray;
        }

        private void btnInserir_MouseLeave(object sender, EventArgs e)
        {
            btnInserir.BackColor = Color.SkyBlue;
        }
    }
}
