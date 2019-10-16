﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Produtos
    {

        Entity.mydbEntities2 DB = new Entity.mydbEntities2();
        public void Cadastrar(Entity.tb_produto_compra produto)
        {
            DB.tb_produto_compra.Add(produto);
            DB.SaveChanges();
        }

        public List<Entity.tb_produto_compra> ListarTodos()
        {
            List<Entity.tb_produto_compra> produtos = DB.tb_produto_compra.ToList();
            return produtos;
        }

        public List<Entity.tb_produto_compra> ListarPorNome(string nome)
        {
            List<Entity.tb_produto_compra> produtos = DB.tb_produto_compra.Where(T => T.nm_produto.Contains(nome))
                                                                      .ToList();
            return produtos;
        }

        public void Alterar(Entity.tb_produto_compra produtos)
        {
            Entity.tb_produto_compra NovoProdutos = DB.tb_produto_compra.FirstOrDefault(t => t.id_produto_compra == produtos.id_produto_compra);


            NovoProdutos.nm_produto = produtos.nm_produto;
            NovoProdutos.qtd_produto = produtos.qtd_produto;
            NovoProdutos.vl_preco = produtos.vl_preco;
            NovoProdutos.id_fornecedor = produtos.id_fornecedor;
           

            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_fornecedor fornecedor = DB.tb_fornecedor.FirstOrDefault(t => t.id_fornecedor == id);

            DB.tb_fornecedor.Remove(fornecedor);
            DB.SaveChanges();
        }


 

    }
}
