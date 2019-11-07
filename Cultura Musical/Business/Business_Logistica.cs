using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Logistica
    {
        Database.Database_Logistica DB = new Database.Database_Logistica();
        public List<Database.Entity.fluxo_de_caixa> FluxodeCaixa()
        {

            List<Database.Entity.fluxo_de_caixa> lista = DB.ConsultarFluxodeCaixa();
            if (lista == null)
            {
                throw new ArgumentException("Nada encontrado");
            }

            return lista;

        }

        public List<Database.Entity.fluxo_de_caixa> ConsultarPorData(DateTime data)
        {

            List<Database.Entity.fluxo_de_caixa> lista = DB.FluxoPorData(data);

            if (lista == null)
            {
                throw new ArgumentException("Nada encontrado nesta data");
            }
            return lista;

        }
    }
}
