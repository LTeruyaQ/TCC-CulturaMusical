using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Planos
    {
       public  List<Database.Entity.tb_plano> listar ()
       {
            Database.Entity.mydbEntities2 db = new Database.Entity.mydbEntities2();
            List<Database.Entity.tb_plano> lista = db.tb_plano.ToList();

            return lista;
       }
    }
}
