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

        public void AdicionarPedido(Entity.tb_compra compra, Entity.tb_produto pedido)
        {
            DB.tb_compra.Add(compra);
            DB.tb_produto.Add(pedido);
            DB.SaveChanges();
        }

        public List<Database.Entity.tb_compra> ListarTodos ()
        {
            List<Database.Entity.tb_compra> pedido = DB.tb_compra.ToList();
            return pedido;
        }

        public void alterar (Database.Entity.tb_compra pedido)
        {
            Database.Entity.tb_compra NovoPedido = DB.tb_compra.FirstOrDefault(t => t.id_compra == pedido.id_compra);

            NovoPedido.dt_entrega = pedido.dt_entrega;
            DB.SaveChanges();
        }

        public void deletar (int id)
        {
            Entity.tb_compra compra = DB.tb_compra.FirstOrDefault(t => t.id_compra == id);

            DB.tb_compra.Remove(compra);
            DB.SaveChanges();
        }
    }
}
