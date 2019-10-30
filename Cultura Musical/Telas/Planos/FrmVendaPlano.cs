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
    public partial class cbo : Form
    {
        Database.Entity.tb_plano plano = new Database.Entity.tb_plano();

        Database.Database_Planos db = new Database.Database_Planos();

        public cbo()
        {
            InitializeComponent();
           


            List<Database.Entity.tb_plano> lista = db.ListarTodos();
            cboplanos.DisplayMember = nameof(plano.nm_plano);
            cboplanos.DataSource = lista;

           

        }
      

        private void cboplanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboplanos.ValueMember = nameof(plano.vl_preco);
            lblvalor0.Text = Convert.ToString(cboplanos.SelectedValue);

            cboplanos.ValueMember = nameof(plano.qtd_aula_semana);
            lblaulas.Text = Convert.ToString(cboplanos.SelectedValue);

            cboplanos.ValueMember = nameof(plano.ds_duracao);
            lblduração.Text = Convert.ToString(cboplanos.SelectedValue);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string nm_cliente = txtnome.Text;
            Database.Database_Cliente cliente = new Database.Database_Cliente();
            int id = cliente.buscarid(nm_cliente);
            cboplanos.ValueMember = nameof(plano.id_plano);
            Database.Entity.tb_venda_plano venda = new Database.Entity.tb_venda_plano();
            venda.id_plano = Convert.ToInt32(cboplanos.SelectedValue);
            venda.id_cliente = id;
            venda.dt_inicio = DateTime.Now.Date;
            venda.dt_fim = dtpfinal.Value;

            db.VendaPlano(venda);

            MessageBox.Show("Venda feita com sucesso.");
        }

        private void txtnome_Leave(object sender, EventArgs e)
        {
            
            
            
    }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            string nm_cliente = txtnome.Text;
            Database.Database_Cliente db = new Database.Database_Cliente();
            List<Database.Entity.tb_cliente> cliente = db.ListarPorNome(nm_cliente);
            dgvlista.DataSource = cliente;
        }
    }
}
