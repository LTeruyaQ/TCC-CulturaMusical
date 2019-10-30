using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Jornada
    {
        Database.Database_Jornada DB = new Database.Database_Jornada();
        public void InserirJornada (Database.Entity.tb_jornada Jornada )
        {
            DB.InserirJornada(Jornada);
        }
    }
}
