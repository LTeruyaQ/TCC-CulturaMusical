using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Funcionarios
    {

        Database.Database_Funcionarios DB = new Database.Database_Funcionarios();


        public void CadastroFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            this.validar(funcionario);
            DB.Cadastrar(funcionario);
            
        }

        public List<Database.Entity.tb_funcionario> ListarPorNome (string nome)
        {
            List<Database.Entity.tb_funcionario> colaborador = DB.ListarPorNome(nome);
            return colaborador;
        }

        public List<Database.Entity.tb_funcionario> ListarPorCargo(string cargo)
        {
            List<Database.Entity.tb_funcionario> colaborador = DB.ListarPorNome(cargo);
            return colaborador;
        }

        public void alterar (Database.Entity.tb_funcionario funcionario)
        {
            this.validar(funcionario);
            DB.ProcurarFuncionario(funcionario);
        }

        public Database.Entity.tb_funcionario BuscarFuncionario (Database.Entity.tb_funcionario Funcionario)
        {
            Database.Entity.tb_funcionario Procura = DB.ProcurarFuncionario(Funcionario);
            return Procura;
        }

        private void validar (Database.Entity.tb_funcionario funcionario)
        {
            if (funcionario.nm_funcionario == string.Empty)
            {
                throw new ArgumentException("O campo do Nome do Funcionario está vazio");
            }

            else if (funcionario.ds_email.Contains("@") == false || funcionario.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo de Email está incorreto ou vazio");
            }

            else if (funcionario.ds_telefone == string.Empty || funcionario.ds_telefone.Length > 10)
            {
                throw new ArgumentException("O campo de Telefone está incorreto ou vazio");
            }

            else if (funcionario.ds_rg == string.Empty || funcionario.ds_rg.Length > 8)
            {
                throw new ArgumentException("O campo de RG está incorreto ou vazio");
            }

            else if (funcionario.dt_nascimento == DateTime.Today)
            {
                throw new ArgumentException("O campo de Data de Nascimento está incorreto");
            }

            else if (funcionario.vl_salario == 0)
            {
                throw new ArgumentException("O campo de Salário está incorreto");
            }

            else if (funcionario.ds_cep == string.Empty)
            {
                throw new ArgumentException("O campo de Salário está vazio");
            }

            else if (funcionario.ds_cargo == string.Empty)
            {
                throw new ArgumentException("O campo de Cargo está vazio");
            }


            else if (funcionario.ds_rua == string.Empty)
            {
                throw new ArgumentException("Os campos de horários estão iguais");
            }

            else if (funcionario.ds_estado == string.Empty)
            {
                throw new ArgumentException("O campo de Estado está vazio");
            }

            else if (funcionario.ds_bairro == string.Empty)
            {
                throw new ArgumentException("O campo Bairro está vazio");
            }

            

        }



    }
}
