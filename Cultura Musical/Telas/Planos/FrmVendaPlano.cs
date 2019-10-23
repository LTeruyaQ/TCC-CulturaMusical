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
        public cbo()
        {
            InitializeComponent();

            Database.Entity.tb_plano plano = new Database.Entity.tb_plano();
            List<Database.Entity.tb_plano> lista = this.Planos();
            
        }
         Database.Entity.culturamusicalEntities DB = new Database.Entity.culturamusicalEntities();


        private List<Database.Entity.tb_plano> Planos()
        {
          
            List<Database.Entity.tb_plano> lista = DB.tb_plano.Where(t=> t.nm_plano == "ouro").ToList();

            return lista;
        }

        private void btnConfirmarPlano_Click(object sender, EventArgs e)
        {

        }
    }
}
