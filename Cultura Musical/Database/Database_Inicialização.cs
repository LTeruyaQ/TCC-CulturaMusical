using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Inicialização
    {

        Entity.mydbEntities3 DB = new Entity.mydbEntities3();


        public void Cadastro(Database.Entity.tb_login cadastro)
        {
           
            DB.SaveChanges();
        }
    }
}
