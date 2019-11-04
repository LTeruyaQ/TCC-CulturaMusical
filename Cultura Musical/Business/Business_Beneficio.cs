using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Beneficio
    {
        Database.Database_Beneficios DB = new Database.Database_Beneficios();
        public void InserirBeneficio(Database.Entity.tb_beneficio Beneficio)
        {
            DB.InserirBeneficio(Beneficio);
        }

       
    }
}
