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

            Business.Business_Planos Bus = new Business.Business_Planos();



            List<Database.Entity.tb_plano> lista = Bus.Plano();
            cboPlano.DisplayMember = nameof(plano.nm_plano);
            cboPlano.DataSource = lista;
        }

       
    }
}
