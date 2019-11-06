using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Beneficios
    {
        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        public void InserirBeneficio(Entity.tb_beneficio Beneficio)
        {
            DB.tb_beneficio.Add(Beneficio);
            DB.SaveChanges();
        }

       
    }
}
