using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Logistica
    {
        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();

        public List<Database.Entity.fluxo_de_caixa> ConsultarFluxodeCaixa()
        {
            List<Database.Entity.fluxo_de_caixa> lista = DB.fluxo_de_caixa.ToList();

            return lista;

        }
        public List<Database.Entity. fluxo_de_caixa> FluxoPorData(DateTime data)
        {
            List<Database.Entity.fluxo_de_caixa> lista = DB.fluxo_de_caixa.Where(t => t.data_pagamento.Month == data.Month
                                                                                                                && t.data_pagamento.Year == data.Year).ToList();

            return lista;

        }
    }

}
