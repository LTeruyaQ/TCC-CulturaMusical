using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Pedidos
    {
        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido,Database.Entity.tb_fornecedor forn)
        {
            Database.Entity.cultura_musicalEntities db = new Database.Entity.cultura_musicalEntities();
            db.tb_produto_compra.Add(pedido);
            db.tb_fornecedor.Add(forn);
            db.SaveChanges();
        }
    }
}
