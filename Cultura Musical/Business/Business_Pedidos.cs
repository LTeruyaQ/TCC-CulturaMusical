using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        Database.Database_Produtos DB = new Database.Database_Produtos();
        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido)
        {
            this.validacao(pedido);
            DB.Cadastrar(pedido);
        }
        
        public List<Database.Entity.tb_produto_compra> ListarPedido(string produto, DateTime data)
        {
            Database.Database_Pedidos pedido = new Database.Database_Pedidos();
            List<Database.Entity.tb_produto_compra> con = pedido.ListarPedido(produto,data);

            return con;

        }

        public void ExcluirPedido (Database.Entity.tb_produto_compra pedido)
        {
          DB.Excluir(pedido.id_produto_compra);
        }

        public void validacao(Database.Entity.tb_produto_compra Produtos)
        {
            Database.Database_Produtos DBProdutos = new Database.Database_Produtos();
            Database.Entity.tb_produto_compra produto = DBProdutos.ListarPorID(Produtos.id_produto_compra);


            if (Produtos.id_fornecedor == 0)
                throw new ArgumentException("É necessario declarar o fornecedor do produto");

            if (Produtos.nm_produto == string.Empty)
                throw new ArgumentException("É necessario declarar o nome do Produto");

            if (Produtos.id_produto_compra == produto.id_produto_compra)
                throw new ArgumentException("Este produto já esta cadastrado");

            if (produto.dt_compra == null)
                throw new ArgumentException("É necessario declarar a data da compra");
        }
    }
}
