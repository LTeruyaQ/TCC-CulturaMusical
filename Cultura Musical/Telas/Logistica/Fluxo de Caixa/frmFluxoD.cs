using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Logistica.Fluxo_de_Caixa
{
    public partial class frmFluxoD : Form
    {

        Business.Business_Logistica bus = new Business.Business_Logistica();
        public frmFluxoD()
        {
            InitializeComponent();

            try
            {
                List<Database.Entity.fluxo_de_caixa> lista = bus.FluxodeCaixa();

                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }



        private void cbomes_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmFluxoD_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime data = dateTimePicker1.Value;

                List<Database.Entity.fluxo_de_caixa> lista = bus.ConsultarPorData(data);

                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
