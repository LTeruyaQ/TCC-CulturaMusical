using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido,Database.Entity.tb_fornecedor forn, Database.Entity.tb_compra compra)
        {
            Database.Database_Pedidos top = new Database.Database_Pedidos();
            top.AdicionarPedido(pedido,forn,compra);
        }

        public List<Database.Entity.tb_produto_compra> ListarPedido(string produto, DateTime data)
        {
            Database.Database_Pedidos pedido = new Database.Database_Pedidos();
            List<Database.Entity.tb_produto_compra> con = pedido.ListarPedido(produto,data);

            return con;

        }
    }
}
