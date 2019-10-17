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


        public List<Database.Entity.tb_produto_compra> ListarProduto()
        {
            
            List<Database.Entity.tb_produto_compra> con = db.ListarProduto();

            return con;
        }

        public void AlterarProduto(Database.Entity.tb_produto_compra altproduto)
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

