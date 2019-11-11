using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Folha_Pagamento
    {
        //Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        Entity.db_a4f9ad_stormprEntities1 DB = new Entity.db_a4f9ad_stormprEntities1();
        public Entity.tb_funcionario ConsultarPorFuncionario(Database.Entity.tb_funcionario fon)
        {
            Entity.tb_funcionario holerites = DB.tb_funcionario.FirstOrDefault(t => t.nm_funcionario == fon.nm_funcionario 
                                                                                       && t.ds_cargo == fon.ds_cargo );
            return holerites;
        }
    }
}
