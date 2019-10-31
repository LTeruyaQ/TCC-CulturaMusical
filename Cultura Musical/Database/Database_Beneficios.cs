using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Beneficios
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();
        public void InserirBeneficio(Entity.tb_beneficio Beneficio)
        {
            DB.tb_beneficio.Add(Beneficio);
            DB.SaveChanges();
        }

       
    }
}
