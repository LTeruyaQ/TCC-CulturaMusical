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
    public partial class frmAlterarFornecedores : Form
    {
        public frmAlterarFornecedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();

            forn.nm_fornecedor = txtRSocial.Text;
            forn.inscricao_estadual = txtInscricao.Text;
            forn.tell_contato = txtTel1.Text;
            forn.tell_contato2 = txtTel2.Text;
            forn.ds_email = txtEmail.Text;
            forn.cep = txtCEP.Text;
            forn.rua = txtRua.Text;
            forn.bairro = txtBairro.Text;
            forn.cidade = txtCidade.Text;
            forn.estado = txtEstado.Text;

            Business.Business_Fornecedores ok = new Business.Business_Fornecedores();
            ok.Alterar(forn);
        }
    }
}
