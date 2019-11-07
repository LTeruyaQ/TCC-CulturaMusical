using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas
{
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        API_s.IBM_Voice ibm = new API_s.IBM_Voice();

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnFalar_Click(object sender, EventArgs e)
        {
            ibm.IniciarOuvir();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            //string texto = ibm.PararOuvir();
            //lblFalar.Text = texto;            
        }

        private void lblFalar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
