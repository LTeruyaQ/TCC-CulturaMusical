using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        public void AdicionarPedido(Database.Entity.tb_produto pedido)
        {
            Database.Database_Pedidos top = new Database.Database_Pedidos();
            top.AdicionarPedido(pedido,forn,compra);
        }

        public List<Database.Entity.tb_produto> ListarPedido(string produto, DateTime data)
        {
            Database.Database_Pedidos pedido = new Database.Database_Pedidos();
            List<Database.Entity.tb_produto> con = pedido.ListarPedido(produto,data);

            return con;
        }
    }
}
