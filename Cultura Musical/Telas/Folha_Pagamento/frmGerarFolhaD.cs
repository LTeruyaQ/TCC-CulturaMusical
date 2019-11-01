using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Folha_Pagamento
{
    public partial class frmGerarFolhaD : Form
    {
        public frmGerarFolhaD()
        {
            InitializeComponent();
        }

        Business.Business_Folha_Pagamento folhaBus = new Business.Business_Folha_Pagamento();
        Business.Business_Financeiro financeiroBus = new Business.Business_Financeiro();

        private void btnprocurar_click(object sender, EventArgs e)
        {
            try
            {
                Database.Entity.tb_funcionario fon = new Database.Entity.tb_funcionario();
                Database.Entity.tb_financeiro Financeiro = new Database.Entity.tb_financeiro();
                Database.Entity.tb_funcionario holerites = folhaBus.ConsultarPorFuncionario(fon);



                    Financeiro.ds_fgts = 8;

                   
                if (holerites.vl_salario >= 1659)
                {
                    Financeiro.ds_inss = 8;
                }

                if (holerites.vl_salario >= 1659 && holerites.vl_salario <= 2765)
                {
                    Financeiro.ds_inss = 9;
                }

                if (holerites.vl_salario >= 2765 && holerites.vl_salario <= 5531)
                {
                    Financeiro.ds_inss = 11;
                }

                if (holerites.vl_salario > 5531)
                {
                    lblINSSDesconto.Text = Convert.ToString(642,34);
                }


                decimal totalprovento = holerites.vl_salario;
                decimal totaldesconto = 

                lblSalarioProvento.Text = Convert.ToString (holerites.vl_salario);
                lblvadesconto.text = convert.tostring(holerites.tb_beneficio.ds_va);
                lblvtdesconto.text = convert.tostring(holerites.tb_beneficio.ds_vt);

                lbltotalprovento.text = convert.tostring(totalprovento);
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

        private void lblTotalDesconto_Click(object sender, EventArgs e)
        {


        }

        private void lblControlINSS_Click(object sender, EventArgs e)
        {

        }

        private void frmGerarFolhaD_Load(object sender, EventArgs e)
        {

        }
    }
}
