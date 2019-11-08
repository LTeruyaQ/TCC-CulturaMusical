using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Inicialização
    {
        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();

        public void Cadastro(Database.Entity.tb_login cadastro)
        {
            DB.tb_login.Add(cadastro);
            DB.SaveChanges();
        }

        public Database.Entity.tb_login procura(Database.Entity.tb_login loguin)
        {
            Database.Entity.tb_login confirmacao = DB.tb_login.FirstOrDefault(t => t.nm_usuario == loguin.nm_usuario
                                                                                && t.sen_usuario == loguin.sen_usuario);

            return confirmacao;

        }
    }
}
