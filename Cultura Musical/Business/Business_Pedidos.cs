﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Pedidos
    {
        public void AdicionarPedido(Database.Entity.tb_produto_compra pedido,Database.Entity.tb_fornecedor forn)
        {
            Database.Database_Pedidos top = new Database.Database_Pedidos();
            top.AdicionarPedido(pedido,forn);
        }
    }
}
