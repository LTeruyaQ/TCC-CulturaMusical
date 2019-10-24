using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Fornecedores
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void cadastrar( Entity.tb_produto prod,Entity.tb_fornecedor forn)
        {
            DB.tb_fornecedor.Add(forn);
            DB.tb_produto.Add(prod);
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

            NovoFornecedor.inscicao_estadual = fornecedor.inscicao_estadual;
            NovoFornecedor.nm_fornecedor = fornecedor.nm_fornecedor;
            NovoFornecedor.rua = fornecedor.rua;
            NovoFornecedor.tell_contato = fornecedor.tell_contato;
            NovoFornecedor.tell_contato2 = fornecedor.tell_contato2;
            NovoFornecedor.bairro = fornecedor.bairro;
            NovoFornecedor.cep = fornecedor.cep;
            NovoFornecedor.cidade = fornecedor.cidade;
            NovoFornecedor.ds_email = fornecedor.ds_email;

            DB.SaveChanges();
        }

        public void excluir(string nome)
        {
            Entity.tb_fornecedor fornecedor = DB.tb_fornecedor.FirstOrDefault(t => t.nm_fornecedor == nome);

            DB.tb_fornecedor.Remove(fornecedor);
            DB.SaveChanges();
        }

       

    }
}
