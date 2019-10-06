using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Inicialização
    {
        public void Cadastro(tb_login cadastro)
        {
            cultura_musicalEntities db = new cultura_musicalEntities();
            db.tb_login.Add(cadastro);
            db.SaveChanges();
        }
    }
}
