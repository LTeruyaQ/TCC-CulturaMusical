using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_DiasDaSemana
    {
        Database.Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();
        
        public void InserirGrade (Entity.tb_dia_semana Dias)
        {
            DB.tb_dia_semana.Add(Dias);
            DB.SaveChanges();
        }
    }
}
