using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Inicialização
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void Cadastro(Database.Entity.tb_login cadastro)
        {           
            DB.SaveChanges();
        }
    }
}
