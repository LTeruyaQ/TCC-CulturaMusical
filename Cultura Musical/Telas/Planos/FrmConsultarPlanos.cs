using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Planos
{
    public partial class FrmConsultarPlanos : Form
    {
        public FrmConsultarPlanos()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            string nome = txtNome.Text;
            Business.Business_Planos bus = new Business.Business_Planos();


            List<Database.Entity.tb_plano> lista =bus.ConsultarNome(nome);

            dataGridView1.DataSource = lista;
        }
    }
}
