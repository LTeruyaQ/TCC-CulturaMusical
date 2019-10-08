using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Funcionarios
    {
        public void Consultar(Database.tb_funcionario funcionario)
        {
            Database.Database_Funcionarios db = new Database.Database_Funcionarios();
            db.Consultar(funcionario);
        }
    }
}
