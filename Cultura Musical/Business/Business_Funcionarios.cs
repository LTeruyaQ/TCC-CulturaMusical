using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Funcionarios
    {
        public void Consultar(Database.Entity.tb_funcionario funcionario)
        {
            if (funcionario.nm_funcionario == string.Empty)
            {
                throw new ArgumentException("O campo do Nome do Funcionario está vazio");
            }

            else if (funcionario.ds_email.Contains("@") == false || funcionario.ds_email == string.Empty)
            {
                throw new ArgumentException("O campo de Email está incorreto ou vazio");
            }

            else if (funcionario.ds_telefone == string.Empty || funcionario.ds_telefone.Length > 12)
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

            else if (funcionario.dt_contratacao == DateTime.)
            {
                throw new ArgumentException("O campo de Data de Nascimento está incorreto");
            }


            Database.Database_Funcionarios db = new Database.Database_Funcionarios();
            db.Consultar(funcionario);
        }

        public void CadastroFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            Database.Database_Funcionarios db = new Database.Database_Funcionarios();
            db.AdicionarFuncionario(funcionario);
        }
    }
}
