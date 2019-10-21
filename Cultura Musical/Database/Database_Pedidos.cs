using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Pedidos
    {

        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void AdicionarPedido(Database.Entity.tb_produto pedido,Database.Entity.tb_fornecedor forn, Database.Entity.tb_compra compra)
        {
          
            DB.tb_produto.Add(pedido);
            DB.tb_fornecedor.Add(forn);
            DB.tb_compra.Add(compra);
            DB.SaveChanges();
        }

        public List<Database.Entity.tb_produto> ListarPedido(string produto)
        {
          
            List<Database.Entity.tb_produto> pedido = DB.tb_produto.Where(t => t.nm_produto == produto )
                                                                                 .ToList();

            return pedido;
        }
    }
}
