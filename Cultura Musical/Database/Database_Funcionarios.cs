using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Funcionarios
    {
        Entity.mydbEntities2 DB = new Entity.mydbEntities2();


        public void Cadastrar(Entity.tb_funcionario funcionario)
        {
            DB.tb_funcionario.Add(funcionario);
            DB.SaveChanges();
        }

        public List<Entity.tb_funcionario> ListarTodos()
        {
            List<Entity.tb_funcionario>funcionarios = DB.tb_funcionario.ToList();
            return funcionarios;
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
        public void AdicionarFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            Database.Entity.mydbEntities2 db = new Database.Entity.mydbEntities2();
            db.tb_funcionario.Add(funcionario);
            db.SaveChanges();
        }

        public List<Database.Entity.tb_funcionario> Consultar (Database.Entity.tb_funcionario funcionario)
        {
            Database.Entity.mydbEntities2 db = new Database.Entity.mydbEntities2();

            List<Database.Entity.tb_funcionario> lista = db.tb_funcionario.Where
                                                  (t => t.nm_funcionario == 
                                                  funcionario.nm_funcionario
                                                  && t.ds_cargo == funcionario.ds_cargo).ToList();
            return lista;
        }   
    }
}
