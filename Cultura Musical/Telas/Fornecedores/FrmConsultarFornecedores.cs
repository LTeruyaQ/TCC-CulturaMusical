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
    public partial class FrmConsultarFornecedores : Form
    {
        public FrmConsultarFornecedores()
        {
            InitializeComponent();

            Business.Business_Fornecedores forn = new Business.Business_Fornecedores();
            List<Database.Entity.tb_fornecedor> ok = forn.ListarForn();

            dgvNMFornecedor.DataSource = ok;
        }

        private void FrmConsultarFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void txtNFornecedor_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNFornecedor.Text;

            Business.Business_Fornecedores forne = new Business.Business_Fornecedores();
            List<Database.Entity.tb_fornecedor> ok = forne.ListarNome(nome);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
