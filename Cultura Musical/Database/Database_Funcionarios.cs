using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Funcionarios
    {
        public void AdicionarFuncionario(tb_funcionario funcionario)
        {
            Database.cultura_musicalEntities db = new Database.cultura_musicalEntities();
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges();
        }

        public List<Database.tb_funcionario> Consultar (tb_funcionario funcionario)
        {
            Database.cultura_musicalEntities db = new Database.cultura_musicalEntities();

            List<Database.tb_funcionario> lista = db.tb_funcionario.Where
                                                  (t => t.nm_funcionario == 
                                                  funcionario.nm_funcionario
                                                  && t.cargo == funcionario.cargo).ToList();
            return lista;
        }   
    }
}
