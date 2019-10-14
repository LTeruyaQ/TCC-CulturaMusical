using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Produtos
    {
        public void ListarPedido(Database.Entity.tb_produto_compra listpedido)
        {
            Database.Entity.mydbEntities2 db = new Entity.mydbEntities2();

            List<Database.Entity.tb_produto_compra> produto = db.tb_produto_compra.OrderBy(t => t.nm_produto).ToList();

        
        }

        public List<Database.Entity.tb_produto_compra> ListarProduto()
        {
            Database.Entity.mydbEntities2 db = new Entity.mydbEntities2();

            List<Database.Entity.tb_produto_compra> produto = db.tb_produto_compra.OrderBy(t => t.nm_produto).ToList();

            return produto;
        }

    }
}
