using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Pedidos
    {
        


        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido,Database.Entity.tb_fornecedor forn, Database.Entity.tb_compra compra)
        {
            Database.Entity.mydbEntities2 db = new Database.Entity.mydbEntities2();
            db.tb_produto_compra.Add(pedido);
            db.tb_fornecedor.Add(forn);
            db.tb_compra.Add(compra);
            db.SaveChanges();
        }

        public List<Database.Entity.tb_produto_compra> ListarPedido(string produto)
        {
            Database.Entity.mydbEntities2 db = new Entity.mydbEntities2();
            List<Database.Entity.tb_produto_compra> pedido = db.tb_produto_compra.Where(t => t.nm_produto == produto).ToList();

            return pedido;
        }
    }
}
