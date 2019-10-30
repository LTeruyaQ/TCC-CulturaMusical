using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        Database.Database_Pedidos DB = new Database.Database_Pedidos();

        public void cadastrar (Database.Entity.tb_compra compra, Database.Entity.tb_produto pedido)
        {
            this.validar(compra);
            DB.AdicionarPedido(compra, pedido);
        }

        public List<Database.Entity.tb_produto> ListarTudo(Database.Entity.tb_produto pedido)
        {
            List<Database.Entity.tb_produto> pedidoo = DB.ListarTodos();
            return pedidoo;
        }

        public List<Database.Entity.tb_produto> ListarProduto(string produto)
        {
            List<Database.Entity.tb_produto> pedido = DB.ListarProduto(produto);
            return pedido;
        }

        public List<Database.Entity.tb_compra> ListarData(DateTime data)
        {
            List<Database.Entity.tb_compra> pedido = DB.ListarData(data);
            return pedido;
        }

        public void alterar (Database.Entity.tb_compra compra)
        {
            this.validar(compra);
            DB.alterar(compra);
        }

        public void Remover(string produto)
        {
            DB.Remover(produto);
        }
        private void validar (Database.Entity.tb_compra compra)
        {
            if (compra.dt_entrega == null)
                throw new ArgumentException("É necessario declarar a data de entraga");
        }
    }
}
