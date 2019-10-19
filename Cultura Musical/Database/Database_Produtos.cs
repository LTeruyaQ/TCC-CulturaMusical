using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Produtos
    {

        Entity.mydbEntities3 DB = new Entity.mydbEntities3();
        public void Cadastrar(Database.Entity.tb_produto produto)
        {
            DB.tb_produto.Add(produto);
            DB.SaveChanges();
        }

        public List<Entity.tb_produto> ListarPorProduto(string produto)
        {
            List<Entity.tb_produto> produtos = DB.tb_produto.Where(T => T.nm_produto.Contains(produto)).OrderBy(t=> t.nm_produto).ToList();
            return produtos;
        }

        public List<Entity.tb_produto> ListarPorNome(string nome)
        {
            List<Entity.tb_produto> produtos = DB.tb_produto.Where(T => T.nm_produto.Contains(nome))
                                                                      .ToList();
            return produtos;
        }

        public void Alterar(Entity.tb_produto produtos)
        {
            Entity.tb_produto NovoProdutos = DB.tb_produto.FirstOrDefault(t => t.id_produto == produtos.id_produto);


            NovoProdutos.nm_produto = produtos.nm_produto;
            NovoProdutos.qtd_produto = produtos.qtd_produto;
            NovoProdutos.vl_preco = produtos.vl_preco;
            NovoProdutos.id_fornecedor = produtos.id_fornecedor;
           

            DB.SaveChanges();
        }

        public void Excluir(string produto)
        {
            Entity.tb_produto pro = DB.tb_produto.FirstOrDefault(t => t.nm_produto == produto);

            DB.tb_produto.Remove(pro);
            DB.SaveChanges();
        }

        public void AlterarProduto(Database.Entity.tb_produto altproduto)
        {
          

            Database.Entity.tb_produto alterar = DB.tb_produto.First(t => t.nm_produto == altproduto.nm_produto);
            alterar.qtd_produto = altproduto.qtd_produto;
            alterar.nm_produto = altproduto.nm_produto;

            



        }

 

    }
}
