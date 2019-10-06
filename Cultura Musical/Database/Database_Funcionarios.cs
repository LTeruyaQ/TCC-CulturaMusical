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
            cultura_musicalEntities db = new cultura_musicalEntities();
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges();
        }
    }
}
