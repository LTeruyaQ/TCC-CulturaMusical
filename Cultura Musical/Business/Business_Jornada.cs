using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Jornada
    {
        Database.Database_Jornada DB = new Database.Database_Jornada();
        public void InserirJornada (Database.Entity.tb_jornada Jornada )
        {
            DB.InserirJornada(Jornada);
        }

        public void Alterar (Database.Entity.tb_jornada jornada)
        {
            DB.Alterar(jornada);
        }

        public void Deletar (int id)
        {
            DB.Deletar(id);
        }

        public List<Database.Entity.tb_jornada> ListaTodos ()
        {
            return DB.ListarTodos();
        }

        public Database.Entity.tb_jornada ProcurarJornada (Database.Entity.tb_jornada jornada)
        {
            return DB.Procurar(jornada);
        }
    }
}
