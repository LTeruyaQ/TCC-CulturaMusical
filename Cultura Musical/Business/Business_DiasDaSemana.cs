using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_DiasDaSemana
    {

        Database.Database_DiasDaSemana DB = new Database.Database_DiasDaSemana();
        public void adicionarEscala (Database.Entity.tb_dia_semana dias)
        {
            DB.InserirGrade(dias);
        }

    }
}
