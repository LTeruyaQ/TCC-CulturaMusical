using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Funcionarios
    {

        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        //Entity.db_a4f9ad_stormprEntities2 DB = new Entity.db_a4f9ad_stormprEntities2();

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

        public List<Entity.tb_funcionario> ListarPorNome(string nome)
        {
            int tamanho = nome.Length;

            List<Entity.tb_funcionario> funcionarios = DB.tb_funcionario.Where(T => T.nm_funcionario.Contains(nome))
                                                                                      
                                                                        .ToList();
            return funcionarios;
        }

        public List<Entity.tb_funcionario> ListarPorCargo(string cargo)
        {


            List<Entity.tb_funcionario> funcionarios = DB.tb_funcionario.Where(T => T.ds_cargo.Contains(cargo))

                                                                        .ToList();
            return funcionarios;
        }

        public void Alterar(Entity.tb_funcionario funcionarios)
        {
            Entity.tb_funcionario Novofuncionario = DB.tb_funcionario.FirstOrDefault(t => t.nm_funcionario == funcionarios.nm_funcionario 
                                                                                       && t.ds_cpf == funcionarios.ds_cpf);
            Novofuncionario.nm_funcionario = funcionarios.nm_funcionario;
            Novofuncionario.vl_salario = funcionarios.vl_salario;
            Novofuncionario.ds_bairro = funcionarios.ds_bairro;
            Novofuncionario.ds_cargo = funcionarios.ds_cargo;
            Novofuncionario.ds_cep = funcionarios.ds_cep;
            Novofuncionario.ds_cpf = funcionarios.ds_cpf;
            Novofuncionario.ds_email = funcionarios.ds_email;
            Novofuncionario.ds_estado = funcionarios.ds_estado;
            Novofuncionario.ds_genero = funcionarios.ds_genero;
            Novofuncionario.ds_rg = funcionarios.ds_rg;
            Novofuncionario.ds_rua = funcionarios.ds_rua;
            Novofuncionario.ds_telefone = funcionarios.ds_telefone;
            Novofuncionario.dt_contratacao = funcionarios.dt_contratacao;
            Novofuncionario.dt_demicao = funcionarios.dt_demicao;
            Novofuncionario.dt_nascimento = funcionarios.dt_nascimento;

            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_funcionario funcionario = DB.tb_funcionario.FirstOrDefault(t => t.id_funcionario == id);

            DB.tb_funcionario.Remove(funcionario);
            DB.SaveChanges();
        }

        public void AdicionarFuncionario(Database.Entity.tb_funcionario funcionario)
        {
            DB.tb_funcionario.Add(funcionario);
            DB.SaveChanges();
        }

       public List<Database.Entity.tb_funcionario> Consultar (Database.Entity.tb_funcionario funcionario)
       {
            List<Database.Entity.tb_funcionario> lista = DB.tb_funcionario.Where
                                                 (t => t.nm_funcionario == 
                                                 funcionario.nm_funcionario
                                                 && t.ds_cargo == funcionario.ds_cargo).ToList();
            return lista;
       }   

        public Database.Entity.tb_funcionario ProcurarFuncionario (Database.Entity.tb_funcionario Funcionario)
        {
            Database.Entity.tb_funcionario Procura = DB.tb_funcionario.FirstOrDefault(t => t.nm_funcionario == Funcionario.nm_funcionario && t.ds_cpf == Funcionario.ds_cpf);
            return Procura;
        }
    }
}
