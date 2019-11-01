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

        Business.Business_Folha_Pagamento folha = new Business.Business_Folha_Pagamento();
        business.business_financeiro finan

        private void btnprocurar_click(object sender, eventargs e)
        {
            try
            {
                database.entity.tb_funcionario fon = new database.entity.tb_funcionario();



                database.entity.tb_funcionario holerites = folha.consultarporfuncionario(fon);
                decimal totalprovento = holerites.vl_salario;
                decimal totaldesconto =
                // + holerites.ds_provento
                lblsalarioprovento.text = convert.tostring(holerites.vl_salario);
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
