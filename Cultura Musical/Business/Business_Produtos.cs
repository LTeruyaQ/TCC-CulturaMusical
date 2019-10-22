using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Produtos
    {

        Database.Database_Produtos DB = new Database.Database_Produtos();

        public void AdicionarProduto (Database.Entity.tb_produto_compra produto)
        {
            this.validacao(produto);
            DB.Cadastrar(produto);
        }
        public List<Database.Entity.tb_produto_compra> ListarProduto()
        {
            List<Database.Entity.tb_produto_compra> Produtos = DB.ListarProduto();
            return Produtos;
        }

        public List<Database.Entity.tb_produto_compra> ListarPorNome(Database.Entity.tb_produto_compra produto)
        {
            List<Database.Entity.tb_produto_compra> produtos = DB.ListarPorNome(produto.nm_produto);
            return produtos;
        }

        public void AlterarProduto(Database.Entity.tb_produto_compra altproduto)
        {
            this.validacao(altproduto);
            DB.Alterar(altproduto);
        }

        public void ExcluirProduto (Database.Entity.tb_produto_compra produto)
        {
            DB.Excluir(produto.id_produto_compra);
        }


        public void validacao (Database.Entity.tb_produto_compra Produtos)
        {
            Database.Database_Produtos DBProdutos = new Database.Database_Produtos();
            Database.Entity.tb_produto_compra produto = DBProdutos.ListarPorID(Produtos.id_produto_compra);


            if (Produtos.id_fornecedor == 0)
                throw new ArgumentException("É necessario declarar o fornecedor do produto");

            if (Produtos.nm_produto == string.Empty)
                throw new ArgumentException("É necessario declarar o nome do Produto");

            if (Produtos.id_produto_compra == produto.id_produto_compra)
                throw new ArgumentException("Este produto já esta cadastrado");

            if (produto.ds_entregue == false)
                throw new ArgumentException("este produto ainda n esta disponivel");
                
        }
    }
}

