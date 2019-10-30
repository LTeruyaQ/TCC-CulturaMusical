using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Jornada
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();
        public void InserirJornada (Entity.tb_jornada Jornada)
        {
            DB.tb_jornada.Add(Jornada);
            DB.SaveChanges();
        }
    }
}
