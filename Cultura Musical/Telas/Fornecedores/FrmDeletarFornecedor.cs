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
    public partial class FrmDeletarFornecedor : Form
    {
        public FrmDeletarFornecedor()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNFornecedor.Text;

                Business.Business_Fornecedores forn = new Business.Business_Fornecedores();
                forn.Remover(nome);

                MessageBox.Show("Fornecedor excluído comm sucesso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique se os caractéres foram digitados corretamente.");
            }
        }
    }
}
