using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Pedidos
    {


        //Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();

        Entity.db_a4f9ad_stormprEntities3 DB = new Entity.db_a4f9ad_stormprEntities3();

        public void AdicionarPedido(Entity.tb_compra compra, Entity.tb_produto pedido)
        {
            DB.tb_compra.Add(compra);
            DB.tb_produto.Add(pedido);
            DB.SaveChanges();
        }

        public List<Database.Entity.tb_produto> ListarTodos()
        {
            List<Database.Entity.tb_produto> pedido = DB.tb_produto.ToList();
            return pedido;
        }


        public List<Database.Entity.tb_produto> ListarProduto(string produto)
        {
            List<Database.Entity.tb_produto> pedido = DB.tb_produto.Where(t=> t.nm_produto == produto).ToList();
            return pedido;
        }

        public List<Database.Entity.tb_compra> ListarData(DateTime data)
        {
            List<Database.Entity.tb_compra> pedido = DB.tb_compra.Where(t => t.dt_compra == data).ToList();
            return pedido;
        }


        public void alterar (Database.Entity.tb_compra pedido)
        {
            Database.Entity.tb_compra NovoPedido = DB.tb_compra.FirstOrDefault(t => t.id_compra == pedido.id_compra);

            NovoPedido.dt_entrega = pedido.dt_entrega;
            DB.SaveChanges();
        }

        public void Remover(string produto)
        {
            Entity.tb_produto compra = DB.tb_produto.FirstOrDefault(t => t.nm_produto == produto);

            DB.tb_produto.Remove(compra);
            DB.SaveChanges();
        }
    }
}
