using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Financeiro
    {
        Database.Database_Financeiro DB = new Database.Database_Financeiro();

        public void inserir (Database.Entity.tb_financeiro financeiro)
        {
            DB.InserirFinanceir(financeiro);
        }
    }
}
