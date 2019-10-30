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
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            Business.Business_Planos planos = new Business.Business_Planos();
            bool ver = planos.verificar(nome);

            if (ver == true)
            {
                MessageBox.Show("Esse plano ja existe");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            plano.nm_plano = txtnome.Text;
            plano.qtd_aula_semana = Convert.ToInt32( nudqtd.Value);
            plano.vl_preco = nudpreço.Value;
            plano.ds_descricao = txtdesc.Text;
            plano.ds_duracao = Convert.ToInt32(txtduração.Text);

            Business.Business_Planos planos = new Business.Business_Planos();
            planos.CadastrarPlano(plano);

            MessageBox.Show("Plano cadastrado com sucesso");
        }
    }
}
