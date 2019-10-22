using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Estoque
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void Cadastrar(Database.Entity.tb_produto addprod)
        {
            DB.tb_produto.Add(addprod);
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
            
            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_produto pro = DB.tb_produto.FirstOrDefault(t => t.id_produto == id);

            DB.tb_produto.Remove(pro);
            DB.SaveChanges();
        }
    }
}
