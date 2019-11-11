﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Estoque
    {
        //Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        Entity.db_a4f9ad_stormprEntities1 DB = new Entity.db_a4f9ad_stormprEntities1();

        public void CadastrarProduto(Database.Entity.tb_produto produto)
        {
            DB.tb_produto.Add(produto);
            DB.SaveChanges();
        }
        public List<Database.Entity.tb_produto> ListarTudo()
        {
            List<Database.Entity.tb_produto> pedido = DB.tb_produto.ToList();
            return pedido;
        }

        public List<Database.Entity.tb_produto> ListarProduto(string produto)
        {
            List<Database.Entity.tb_produto> pedido = DB.tb_produto.Where(t => t.nm_produto == produto).ToList();
            return pedido;
        }

    }
}
