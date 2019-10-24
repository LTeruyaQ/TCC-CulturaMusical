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

        

        private void btn_Procurar(object sender, EventArgs e)
        {
            Database.Entity.tb_funcionario fon = new Database.Entity.tb_funcionario();
            
            
            Business.Business_Folha_Pagamento folha = new Business.Business_Folha_Pagamento();
            Database.Entity.tb_funcionario holerites = folha.ConsultarPorFuncionario( fon);

            lblSalarioProvento.Text = Convert.ToString(holerites.vl_salario);
            lblVAProvento.Text = Convert.ToString(fon.tb_beneficio.ds_va);
            lblVTProvento.Text = Convert.ToString(fon.tb_beneficio.ds_vt);
            
        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }
    }
}
