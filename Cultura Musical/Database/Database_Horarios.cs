using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Horarios
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void AdicionarEscala (Entity.tb_horario horario)
        {
            DB.tb_horario.Add(horario);
            DB.SaveChanges();
        }
    }
}
