using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Pedidos
    {

        Entity.mydbEntities3 DB = new Entity.mydbEntities3();

        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido,Database.Entity.tb_fornecedor forn, Database.Entity.tb_produto_compra compra)
        {
            
            DB.tb_produto_compra.Add(pedido);
            DB.tb_fornecedor.Add(forn);
            DB.tb_produto_compra.Add(compra);
            DB.SaveChanges();
        }

        public List<Database.Entity.tb_produto_compra> ListarPedido(string produto)
        {
            
            List<Database.Entity.tb_produto_compra> pedido = DB.tb_produto_compra.Where(t => t.nm_produto == produto).ToList();

            return pedido;
        }
    }
}
