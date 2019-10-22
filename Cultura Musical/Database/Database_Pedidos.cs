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

        public void AdicionarPedido()
        { 
            DB.tb_compra.Add
        }

        public List<Database.Entity.tb_compra_item> ListarPedidoPorProduto(int id)
        {
          
            List<Database.Entity.tb_compra_item> pedido = DB.tb_compra_item.Where(t => t.id_compra == id )
                                                                                 .ToList();

            return pedido;
        }

        public List<Database.Entity.tb_compra_item> ListarTodos ()
        {
            List<Database.Entity.tb_compra_item> pedido = DB.tb_compra_item.ToList();
            return pedido;
        }

        public void alterar (Database.Entity.tb_compra_item pedido)
        {
            Database.Entity.tb_compra_item NovoPedido = DB.tb_compra_item.FirstOrDefault(t => t.id_compra == pedido.id_compra 
                                                                                           && t.id_produto == pedido.id_produto);

            NovoPedido.id_produto = pedido.id_produto;
            NovoPedido.id_compra = pedido.id_compra;
        }
    }
}
