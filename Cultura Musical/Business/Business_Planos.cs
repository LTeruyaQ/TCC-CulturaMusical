using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Planos
    {
        public List<Database.Entity.tb_plano> Plano ()
        {
            Database.Database_Planos db = new Database.Database_Planos();
            List<Database.Entity.tb_plano> lista = db.listar();

            return lista;
        }   
    }
}
