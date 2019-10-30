using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database.Entity
{


    public partial class tb_produto
    {
        public DateTime dt_compra { get { return this.tb_compra.dt_compra; }}
        public DateTime dt_entrega { get { return this.tb_compra.dt_entrega; } }

        public string nm_fornecedor {  get { return this.tb_compra.tb_fornecedor.nm_fornecedor; } }
    }

  

    
}
