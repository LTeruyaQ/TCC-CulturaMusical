using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        Database.Database_Pedidos DB = new Database.Database_Pedidos();

        public void cadastrar (Database.Entity.tb_compra compra)
        {
            this.validar(compra);
            DB.AdicionarPedido(compra);
        }

        public List<Database.Entity.tb_compra> listarTodos ()
        {
            List<Database.Entity.tb_compra> pedido = DB.ListarTodos();
            return pedido;
        }

        public void alterar (Database.Entity.tb_compra compra)
        {
            this.validar(compra);
            DB.alterar(compra);
        }

        public void deletar (int id)
        {
            DB.deletar(id);
        }
       public void validar (Database.Entity.tb_compra compra)
        {
            if (compra.dt_entrega == null)
                throw new ArgumentException("É necessario declarar a data de entraga");
        }
    }
}
