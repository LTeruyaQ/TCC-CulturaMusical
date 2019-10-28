using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cultura_Musical.Telas.Funcionarios
{
    public partial class frmConsultarFuncionarioD : Form
    {
        public frmConsultarFuncionarioD()
        {
            InitializeComponent();
        }

        private void frmConsultarFuncionarioD_Load(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "------------------";
                dataGridView1.Rows[n].Cells[1].Value = "------------------ ";
                dataGridView1.Rows[n].Cells[2].Value = "-------------------";
                dataGridView1.Rows[n].Cells[3].Value = "-------------------";
                dataGridView1.Rows[n].Cells[4].Value = "-------------------";

            }

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
        

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
