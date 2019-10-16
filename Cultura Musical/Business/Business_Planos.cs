using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Planos
    {
        Database.Database_Planos db = new Database.Database_Planos();
        public List<Database.Entity.tb_plano> Plano ()
        {
            
            List<Database.Entity.tb_plano> lista = db.ListarTodos();

            return lista;
        }   
    }
}
