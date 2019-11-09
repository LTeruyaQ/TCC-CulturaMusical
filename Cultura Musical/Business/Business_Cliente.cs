using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Cliente
    {


        Database.Database_Cliente db = new Database.Database_Cliente();
        public List<Database.Entity.tb_cliente> listapornome(string nome)
        {
            List<Database.Entity.tb_cliente> lista = db.ListarPorNome(nome);

            return lista;
        }

        public void CadastrarCliente(Database.Entity.tb_cliente cliente)
        {

            db.cadastrar(cliente);

        }
    }
}
