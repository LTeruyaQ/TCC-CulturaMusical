using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Fornecedores
    {
        public void AddForn(Database.Entity.tb_fornecedor forn, Database.Entity.tb_produto prod)
        {
            Database.Database_Fornecedores top = new Database.Database_Fornecedores();
            top.cadastrar(prod, forn); 
        }

        public List<Database.Entity.tb_fornecedor> ListarForn()
        {
            Database.Database_Fornecedores forn = new Database.Database_Fornecedores();
            List<Database.Entity.tb_fornecedor> ok = forn.ListarTodos();

            return ok;
        }

        public List<Database.Entity.tb_fornecedor> ListarNome(string nome)
        {
            Database.Database_Fornecedores forn = new Database.Database_Fornecedores();
            List<Database.Entity.tb_fornecedor> ok = forn.ListarPorNome(nome);

            return ok;
        }

        public void Remover(string forn)
        {
            Database.Database_Fornecedores forne = new Database.Database_Fornecedores();
            forne.excluir(forn);
        }

        public void Alterar(Database.Entity.tb_fornecedor forn)
        {
            Database.Database_Fornecedores forne = new Database.Database_Fornecedores();
            forne.alterar(forn);
        }
    }
}
