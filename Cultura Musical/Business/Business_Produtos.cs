using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Produtos
    {
        Database.Database_Produtos db = new Database.Database_Produtos();

        public void CadastrarProduto(Database.Entity.tb_produto addprod)
        {
            if (addprod.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Produto não foi preenchdo");
            }
            else if (addprod.qtd_produto == 0)
            {
                throw new ArgumentException("Determine a quantidade do produto selecionado");
            }
            else if (addprod.vl_preco == 0)
            {
                throw new ArgumentException("Determiinne um preço para o produto selecionado");
            }

            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.Cadastrar(addprod);
        }

        public List<Database.Entity.tb_produto> ListarPorProduto(string produto)
        {
            List<Database.Entity.tb_produto> con = db.ListarPorProduto(produto);

            return con;
        }

        public void AlterarProduto(Database.Entity.tb_produto altproduto)
        {
            if (altproduto.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Produto não foi preenchdo");
            }
            else if (altproduto.qtd_produto == 0)
            {
                throw new ArgumentException("Determine a quantidade do produto selecionado");
            }
            else if (altproduto.vl_preco == 0)
            {
                throw new ArgumentException("Determine um preço para o produto selecionado");
            }

            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.AlterarProduto(altproduto);
        }

        public void Remover(string produto)
        {
            if (produto == string.Empty)
            {
                throw new ArgumentException("Selecione o produto");
            }
            
            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.Excluir(produto);
        }
    }
}

