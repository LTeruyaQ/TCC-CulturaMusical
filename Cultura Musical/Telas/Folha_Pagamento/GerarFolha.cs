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

        Database.Database_Folha_Pagamento folhaBus = new Database.Database_Folha_Pagamento();
        Database.Database_Funcionarios funcionarioBus = new Database.Database_Funcionarios();
        

        private void btn_Procurar(object sender, EventArgs e)
        {
            try
            {


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

     

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }
    }
}
