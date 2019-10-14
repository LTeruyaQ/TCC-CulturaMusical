using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Inicialização
    {
        public void Cadastro(Database.Entity.tb_login cadastro)
        {
            Database.Entity.mydbEntities2 db = new Database.Entity.mydbEntities2();
            db.tb_login.Add(cadastro);
            db.SaveChanges();
        }
    }
}
