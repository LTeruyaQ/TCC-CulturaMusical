using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Cliente
    {
        public List<Database.Entity.tb_cliente> listapornome(string nome)
        {

            Database.Database_Cliente cliente = new Database.Database_Cliente();
            List<Database.Entity.tb_cliente> lista = cliente.ListarPorNome(nome);

            return lista;
        }
    }
}
