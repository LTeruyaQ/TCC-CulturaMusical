﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Estoque
    {
        Database.Database_Estoque db = new Database.Database_Estoque();

        public void CadastrarProduto(Database.Entity.tb_produto addprod)
        {
            this.validacao(addprod);

            Database.Database_Estoque pro = new Database.Database_Estoque();
            pro.Cadastrar(addprod);
        }

        public List<Database.Entity.tb_produto> ListarPorProduto(string produto)
        {
            List<Database.Entity.tb_produto> con = db.ListarPorProduto(produto);

            return con;
        }

        public void AlterarProduto(Database.Entity.tb_produto altproduto)
        {

            this.validacao(altproduto);
            Database.Database_Estoque pro = new Database.Database_Estoque();
            pro.Alterar(altproduto);
        }

        public void Remover(int id)
        {
            if (id == 0)
            {
                throw new ArgumentException("Selecione o produto");
            }
            
            Database.Database_Estoque pro = new Database.Database_Estoque();
            pro.Excluir(id);
        }

        public void validacao (Database.Entity.tb_produto produto)
        {
            if (produto.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo Produto não foi preenchdo");
            }
            else if (produto.qtd_produto == 0)
            {
                throw new ArgumentException("Determine a quantidade do produto selecionado");
            }
            else if (produto.vl_preco == 0)
            {
                throw new ArgumentException("Determine um preço para o produto selecionado");
            }
        }
    }
}
