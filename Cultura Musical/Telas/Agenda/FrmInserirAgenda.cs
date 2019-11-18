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
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void InserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.FrmAgenda Telas = new FrmAgenda();
            Telas.Show();
            this.Close();
            
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente deseja fechar o sistema ?", "Cultura Musical",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Telas.FrmHomePage tela = new FrmHomePage();
            tela.Show();
            this.Hide();
        }
    }
}
