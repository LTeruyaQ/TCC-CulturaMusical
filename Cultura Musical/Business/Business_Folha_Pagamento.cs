﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Folha_Pagamento
    {
        Database.Database_Folha_Pagamento folha = new Database.Database_Folha_Pagamento();
        public void ExtrairSalario(string func, Database.Entity.tb_funcionario fon)
        {
            folha.ExtrairSalario(func, fon);


        }
    }
}
