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
    public partial class frmAlterarFornecedor : Form
    {
        public frmAlterarFornecedor()
        {
            InitializeComponent();

            Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();

            this.CarregarCampos(forn);
        }

        Business.Business_Fornecedores Bus = new Business.Business_Fornecedores();

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_fornecedor forn = new Database.Entity.tb_fornecedor();

                forn.nm_fornecedor = txtRSocial.Text;
                forn.inscicao_estadual = txtInscricao.Text;
                forn.tell_contato = mskTel1.Text;
                forn.tell_contato2 = mskTel2.Text;
                forn.ds_email = txtEmail.Text;
                forn.cep = mskCEP.Text;
                forn.rua = txtRua.Text.ToLower();
                forn.bairro = txtBairro.Text.ToLower();
                forn.cidade = txtCidade.Text.ToLower();
                forn.estado = txtEstado.Text.ToLower();
                forn.ds_cnpj = mstCNPJ.Text;
                forn.nmr_fornecedor = Convert.ToInt32(nudnumero.Value);


                Business.Business_Fornecedores forne = new Business.Business_Fornecedores();
                forne.AddForn(forn);

                MessageBox.Show("Fornecedor adicionado com sucesso.");

                DialogResult r = MessageBox.Show("Fornecedor cadastrado com sucesso.", "Cultura Musical",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                this.LimparCampos();
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

        private void LimparCampos()
        {
             txtRSocial.Text = string.Empty;
             txtInscricao.Text = string.Empty;
             mskTel1.Text = string.Empty;
             txtEmail.Text = string.Empty;
             mskCEP.Text = string.Empty;
             txtRua.Text = string.Empty;
             txtBairro.Text = string.Empty;
             txtCidade.Text = string.Empty;
             txtEstado.Text = string.Empty;
             mstCNPJ.Text = string.Empty;
             nudnumero.Value = 0;


        }

        private void CarregarCampos(Database.Entity.tb_fornecedor forn)
        {
            forn.nm_fornecedor = txtRSocial.Text;
            forn.inscicao_estadual = txtInscricao.Text;
            forn.tell_contato = mskTel1.Text;
            forn.tell_contato2 = mskTel2.Text;
            forn.ds_email = txtEmail.Text;
            forn.cep = mskCEP.Text;
            forn.rua = txtRua.Text.ToLower();
            forn.bairro = txtBairro.Text.ToLower();
            forn.cidade = txtCidade.Text.ToLower();
            forn.estado = txtEstado.Text.ToLower();
            forn.ds_cnpj = mstCNPJ.Text;
            forn.nmr_fornecedor = Convert.ToInt32(nudnumero.Value);


            Bus.BuscarFornecedor(forn);

        }


    }
}
