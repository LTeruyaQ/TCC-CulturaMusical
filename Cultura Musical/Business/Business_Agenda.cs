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

        public void cadastrar (Database.Entity.tb_aula aula)
        {
            this.validacao(aula);
            DB.cadastrar(aula);
        }

        public void alterar (Database.Entity.tb_aula aula)
        {
            this.validacao(aula);
            DB.alterar(aula);
        }

        public List<Database.Entity.tb_aula> consultarpordata(DateTime data)
        {
            return DB.ListarPorData(data);
        }

        public List<Database.Entity.tb_aula> consultartodos ()
        {
            return DB.ListarTodos();
        }

        public void axcluir (int id)
        {
            
            DB.excluir(id);
        }

        private void validacao (Database.Entity.tb_aula aula)
        {

            Database.Entity.tb_aula validar_funcionario = DB.validaFuncionario(aula);
            Database.Entity.tb_aula validar_cliente = DB.validaCliente(aula);
            Database.Entity.tb_aula validar_sala = DB.validaSala(aula);
            Database.Entity.tb_aula validar_contrato = DB.validarContrato(aula);


            if (aula.dt_aula == null)
                throw new ArgumentException("É necessario declarar a data da aula");

            if (aula.hr_aula == null)
                throw new ArgumentException("É necessario declarar o horario da aula");

            if (aula.tp_aula == string.Empty)
                throw new ArgumentException("É necessario declarar o tipo da aula");

            if (aula.id_cliente == validar_cliente.id_cliente)
                throw new ArgumentException("Este aluno ja tem compromisso neste horario");

            if (aula.id_funcionario == validar_funcionario.id_funcionario)
                throw new ArgumentException("Este professor já tem compromisso neste horario");

            if (aula.id_sala == validar_sala.id_sala)
                throw new ArgumentException("Esta sala já esta em uso neste horario");

            if (aula.id_venda_plano == validar_contrato.id_venda_plano)
                throw new ArgumentException("O plano em deste aluno não possibilita esta ação");
        }
    }
}
