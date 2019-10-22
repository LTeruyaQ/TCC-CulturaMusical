using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Agenda
    {
        Database.Database_Agenda DB = new Database.Database_Agenda();
        public void cadastroAula (Database.Entity.tb_cliente_aula agenda)
        {
            this.cadastroAula(agenda);
            DB.cadastrar(agenda);
        }

        public void AlteracaoAula (Database.Entity.tb_cliente_aula agenda)
        {
            this.validação(agenda);
            DB.alterar(agenda);
        }

        public void DescartarAula(Database.Entity.tb_cliente_aula agenda)
        {
            DB.excluir(agenda.id_aula);
        }

        public List<Database.Entity.tb_cliente_aula> ConsultaGeral ()
        {
           List<Database.Entity.tb_cliente_aula> aulas = DB.ListarTodos();
            return aulas;
        }
        
        public List<Database.Entity.tb_cliente_aula> ConsultarPorData (DateTime date)
        {
            List<Database.Entity.tb_cliente_aula> aulas = DB.ListarPordata(date);
            return aulas;
        }

        public List<Database.Entity.tb_cliente_aula> ConsultarPorAluno(Database.Entity.tb_cliente_aula agenda)
        {
            List<Database.Entity.tb_cliente_aula> aulas = DB.ListarPorAluno(agenda);
            return aulas;
        }

        public List<Database.Entity.tb_cliente_aula> ConsultarPorProfessor(Database.Entity.tb_cliente_aula agenda)
        {
            List<Database.Entity.tb_cliente_aula> aulas = DB.ListarPorProfessor(agenda);
            return aulas;
        }

        public void validação (Database.Entity.tb_cliente_aula agenda)
        {
            Database.Database_Agenda DBAulas = new Database.Database_Agenda();

            Database.Entity.tb_cliente_aula compromisso = DB.varificar(agenda);

            if (agenda.dt_aula == compromisso.dt_aula
                && agenda.hr_aula == compromisso.hr_aula
                && agenda.id_sala == compromisso.id_sala)
                throw new ArgumentException("Este horario e sala já esta ocupado");

            if (agenda.id_funcionario == compromisso.id_funcionario)
                throw new ArgumentException("Este funcionario já sendo requisitado em outra atividade");

            if (agenda.id_cliente == 0)
                throw new ArgumentException("É necessario declarar o aluno em questão");

            if (agenda.id_funcionario == 0)
                throw new ArgumentException("É necessario declarar o Funcionario encarregado");

            if (agenda.id_sala == 0)
                throw new ArgumentException("É necessario declarar o local que sera usado para a aula");

            if (agenda.hr_aula == null)
                throw new ArgumentException("É necessario declarar o horario da aula");

            if (agenda.dt_aula == null)
                throw new ArgumentException("É necessario declarar a data da aula");

        }
    }
}
