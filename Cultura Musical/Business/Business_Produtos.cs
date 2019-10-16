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
            
            List<Database.Entity.tb_produto_compra> con = db.ListarTodos();

            return con;
        }
    }
}
