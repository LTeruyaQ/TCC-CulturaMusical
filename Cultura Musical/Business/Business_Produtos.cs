using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Produtos
    {
        public List<Database.Entity.tb_produto_compra> ListarProduto()
        {
            Database.Database_Produtos pro = new Database.Database_Produtos();
            List<Database.Entity.tb_produto_compra> con = pro.ListarTodos();

            return con;
        }

        public void Remover (string produto)
        {
            Database.Database_Produtos db = new Database.Database_Produtos();
            db.Remover(produto);
        }
    }
}
