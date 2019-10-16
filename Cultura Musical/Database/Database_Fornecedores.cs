using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Fornecedores
    {
        Entity.mydbEntities2 DB = new Entity.mydbEntities2();
        public void cadastrar(Entity.tb_fornecedor fornecedor)
        {
            DB.tb_fornecedor.Add(fornecedor);
            DB.SaveChanges();
        }

        public List<Entity.tb_fornecedor> ListarTodos()
        {
            List<Entity.tb_fornecedor> fornecedores = DB.tb_fornecedor.ToList();
            return fornecedores;
        }

        public List<Entity.tb_fornecedor> ListarPorNome(string nome)
        {
            List<Entity.tb_fornecedor> fornecedores = DB.tb_fornecedor.Where(T => T.nm_fornecedor.Contains(nome))
                                                                      .ToList();
            return fornecedores;
        }

        public void alterar(Entity.tb_fornecedor fornecedor)
        {
            Entity.tb_fornecedor NovoFornecedor = DB.tb_fornecedor.FirstOrDefault(t => t.id_fornecedor == fornecedor.id_fornecedor);

            NovoFornecedor.inscricao_estadual = fornecedor.inscricao_estadual;
            NovoFornecedor.nm_fornecedor = fornecedor.nm_fornecedor;
            NovoFornecedor.rua = fornecedor.rua;
            NovoFornecedor.tb_produto_compra = fornecedor.tb_produto_compra;
            NovoFornecedor.tell_contato = fornecedor.tell_contato;
            NovoFornecedor.tell_contato2 = fornecedor.tell_contato2;

            DB.SaveChanges();
        }

        public void excluir(int id)
        {
            Entity.tb_fornecedor fornecedor = DB.tb_fornecedor.FirstOrDefault(t => t.id_fornecedor == id);

            DB.tb_fornecedor.Remove(fornecedor);
            DB.SaveChanges();
        }

    }
}
