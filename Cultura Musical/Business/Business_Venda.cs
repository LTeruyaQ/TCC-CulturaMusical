using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Venda
    {

        Database.Database_Vendas db = new Database.Database_Vendas();
        public List<Database.Entity.tb_venda_plano> ListarTodos()
        {
            List<Database.Entity.tb_venda_plano> vendas = db.ListarTodos();
            return vendas;
        }
    }
}
