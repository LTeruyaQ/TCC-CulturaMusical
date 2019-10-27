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
            try
            {
                Database.Entity.tb_funcionario fon = new Database.Entity.tb_funcionario();

                Business.Business_Folha_Pagamento folha = new Business.Business_Folha_Pagamento();
                Database.Entity.tb_funcionario holerites = folha.ConsultarPorFuncionario(fon);

                decimal totaldesconto = holerites.tb_financeiro.ds_inss + holerites.tb_beneficio.ds_va + holerites.tb_beneficio.ds_vr + holerites.tb_beneficio.ds_vt;
                decimal totalprovento = holerites.vl_salario ;
                // + holerites.ds_provento
                lblSalarioProvento.Text = Convert.ToString(holerites.vl_salario);
                lblVADesconto.Text = Convert.ToString(holerites.tb_beneficio.ds_va);
                lblVTDesconto.Text = Convert.ToString(holerites.tb_beneficio.ds_vt);
                lblINSSDesconto.Text = Convert.ToString(holerites.tb_financeiro.ds_inss);
                lblTotalDesconto.Text = Convert.ToString(totaldesconto);
                lblTotalProvento.Text = Convert.ToString(totalprovento);
                lblValorLiquido.Text = Convert.ToString(totaldesconto + totalprovento);
            }
            catch (Exception)
            {
                MessageBox.Show("Houve algum erro na filtragem de dados.");
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }
    }
}
