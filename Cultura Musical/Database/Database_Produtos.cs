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
            Database.Entity.cultura_musicalEntities db = new Entity.cultura_musicalEntities();

            List<Database.Entity.tb_produto_compra> produto = db.tb_produto_compra.OrderBy(t => t.nm_produto).ToList();

        
        }
    }
}
