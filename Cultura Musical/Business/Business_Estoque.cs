using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Estoque
    {

        Database.Database_Estoque DB = new Database.Database_Estoque();

        public void CadastrarProduto(Database.Entity.tb_produto cadastro)
        {
            DB.CadastrarProduto(cadastro);
        }

        public void AlterarProduto(Database.Entity.tb_produto altproduto)
        {
            DB.AlterarProduto(altproduto);
        }

        public List<Database.Entity.tb_produto> ListarTudo()
        {
            List<Database.Entity.tb_produto> produto =  DB.ListarTudo();

            return produto;
        }

        public List<Database.Entity.tb_produto> ListarProduto(string produto)
        {
            List<Database.Entity.tb_produto> produtoo = DB.ListarProduto(produto);

            return produtoo;
        }
    }
}

