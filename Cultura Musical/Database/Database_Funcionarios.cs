using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Funcionarios
    {
        public void AdicionarFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            Database.Entity.mydbEntities1 db = new Database.Entity.mydbEntities1();
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges();
        }

        public List<Database.Entity.tb_funcionario> Consultar (Database.Entity.tb_funcionario funcionario)
        {
            Database.Entity.mydbEntities1 db = new Database.Entity.mydbEntities1();

            List<Database.Entity.tb_funcionario> lista = db.tb_funcionario.Where
                                                  (t => t.nm_funcionario == 
                                                  funcionario.nm_funcionario
                                                  && t.ds_cargo == funcionario.ds_cargo).ToList();
            return lista;
        }   
    }
}
