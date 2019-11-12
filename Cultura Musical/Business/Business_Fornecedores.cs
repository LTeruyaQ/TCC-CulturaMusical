using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Fornecedores
    {
        Database.Database_Fornecedores DB = new Database.Database_Fornecedores();

        public void AddForn(Database.Entity.tb_fornecedor forn)
        {
            this.validacao(forn);            
            DB.cadastrar(forn); 
        }

        public List<Database.Entity.tb_fornecedor> ListarForn()
        {
            List<Database.Entity.tb_fornecedor> ok = DB.ListarTodos();

            return ok;
        }

        public List<Database.Entity.tb_fornecedor> ListarNome(string nome)
        {           
          List<Database.Entity.tb_fornecedor> ok = DB.ListarPorNome(nome);

            return ok;
        }


        public Database.Entity.tb_fornecedor BuscarFornecedor(Database.Entity.tb_fornecedor forn)
        {
            Database.Entity.tb_fornecedor Procura = DB.ProcurarFornecedor(forn);
            return Procura;
        }


        public void Remover(int id)
        {
            DB.excluir(id);
        }

        public void Alterar(Database.Entity.tb_fornecedor forn)
        {
            this.validacao(forn);
            DB.alterar(forn);
        }

        private void validacao(Database.Entity.tb_fornecedor forn)
        {
            if (forn.ds_email.Contains("@") == false || forn.ds_email == string.Empty)
                throw new ArgumentException("O campo de email está incorreto");

            else if (forn.inscicao_estadual == string.Empty || forn.inscicao_estadual.Length > 15)

                throw new ArgumentException("O campo de Inscrição Estadual está incorreto");

            else if (forn.nm_fornecedor == string.Empty)

                throw new ArgumentException("O nome do fornecedor está vazio");

            else if (forn.tell_contato == string.Empty || forn.tell_contato.Length > 14)

                throw new ArgumentException("O campo de Telefone(1) está incorreto");

            else if (forn.tell_contato2 == string.Empty || forn.tell_contato2.Length > 14)

                throw new ArgumentException("O campo de Telefone(2) está incorreto");

            else if (forn.rua == string.Empty)

                throw new ArgumentException("O campo 'Rua' está vazio");

            else if (forn.estado == string.Empty)

                throw new ArgumentException("O campo 'Estado' está vazio");

            else if (forn.bairro == string.Empty)

                throw new ArgumentException("O campo 'Bairro' está vazio");

            else if (forn.cep.Length > 9 || forn.cep == string.Empty)

                throw new ArgumentException("O campo 'CEP' está vazio ou incorreto");

            else if (forn.cidade == string.Empty)

                throw new ArgumentException("O campo 'Cidade' está vazio");
        }
    }
}
