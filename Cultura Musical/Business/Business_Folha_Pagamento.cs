using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Folha_Pagamento
    {
        Database.Database_Folha_Pagamento folha = new Database.Database_Folha_Pagamento();

        public Database.Entity.tb_funcionario ConsultarPorFuncionario(Database.Entity.tb_funcionario fon)
        {
           Database.Entity.tb_funcionario holerites = folha.ConsultarPorFuncionario(fon);
           return holerites;
        }
    }
}
