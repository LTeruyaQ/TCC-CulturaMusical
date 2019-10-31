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
    public partial class frmAdicionarPlano : Form
    {
        Database.Entity.tb_plano plano = new Database.Entity.tb_plano();
        public frmAdicionarPlano()
        {
            InitializeComponent();
            Database.Database_Planos planos = new Database.Database_Planos();
            List<Database.Entity.tb_plano> lista = planos.ListarTodos();

            cbonome.DisplayMember = nameof(plano.nm_plano);
            cbonome.DataSource = lista;


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            plano.nm_plano = txtnome.Text;
            plano.qtd_aula_semana = Convert.ToInt32( nudqtd.Value);
            plano.vl_preco = nudpreço.Value;
            plano.ds_descricao = txtdesc.Text;
            plano.ds_duracao = Convert.ToInt32(txtduração.Text);

            
            Business.Business_Planos bus = new Business.Business_Planos();
            bus.CadastrarPlano(plano);

            MessageBox.Show("Plano cadastrado com sucesso");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbonome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonome.ValueMember = nameof(plano.vl_preco);
            nudalterar.Value= Convert.ToDecimal(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.qtd_aula_semana);
            nud_qtd_alterar.Value = Convert.ToDecimal(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.ds_duracao);
            txtduraçãoalterar.Text = Convert.ToString(cbonome.SelectedValue);

            cbonome.ValueMember = nameof(plano.ds_descricao);
            txtdescalterar.Text = Convert.ToString(cbonome.SelectedValue);
        }
    }
}
