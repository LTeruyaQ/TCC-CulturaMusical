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
            if(forn.ds_email.Contains("@") == false || forn.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo de email está incorreto");

            }

            else if(forn.inscicao_estadual == string.Empty || forn.inscicao_estadual.Length != 9)
            {
                throw new ArgumentException("O campo de Inscrição Estadual está incorreto");
            }


            else if(forn.nm_fornecedor == string.Empty)
            {
                throw new ArgumentException("O nome do fornecedor está vazio");

            }

        
            else if (forn.tell_contato == string.Empty || forn.tell_contato.Length > 12)
            {
                throw new ArgumentException("O campo de Telefone(1) está incorreto");
            }


            else if (forn.tell_contato2 == string.Empty || forn.tell_contato2.Length > 12)
            {
                throw new ArgumentException("O campo de Telefone(2) está incorreto");
            }

            else if(prod.nm_produto == string.Empty)
            {
                throw new ArgumentException("O campo de Fornecimento está vazio");
            }

            else if(forn.rua == string.Empty)
            {
                throw new ArgumentException("O campo 'Rua' está vazio");
            }

            else if(forn.estado == string.Empty)
            {
                throw new ArgumentException("O campo 'Estado' está vazio");
            }

            else if(forn.bairro == string.Empty)
            {
                throw new ArgumentException("O campo 'Bairro' está vazio");
            }

            else if(forn.cep.Length > 8 || forn.cep == string.Empty)
            {
                throw new ArgumentException("O campo 'CEP' está vazio ou incorreto");
            }

            else if (forn.cidade == string.Empty)
            {
                throw new ArgumentException("O campo 'Cidade' está vazio");
            }

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
