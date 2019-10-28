using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Horarios
    {

        Database.Database_Horarios DB = new Database.Database_Horarios();

        public void AdicionarEscala (Database.Entity.tb_horario Horarios)
        {
            DB.AdicionarEscala(Horarios);
        }
    }
}
