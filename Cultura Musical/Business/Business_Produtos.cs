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

        public void CadastrarProduto(Database.Entity.tb_produto altproduto)
        {
            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.Cadastrar(altproduto);
        }

        public List<Database.Entity.tb_produto> ListarPorProduto(string produto)
        {
            
            List<Database.Entity.tb_produto> con = db.ListarPorProduto(produto);

            return con;
        }

        public void AlterarProduto(Database.Entity.tb_produto altproduto)
        {
            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.AlterarProduto(altproduto);
        }

        public void Remover(string produto)
        {
            Database.Database_Produtos pro = new Database.Database_Produtos();
            pro.Excluir(produto);

        }
    }
}

