using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Agenda : Interfaces.Interface_Crud<Entity.tb_agenda_estudio>
    {
        // EU n sei fazer implementação




        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        //Entity.db_a4f9ad_stormprEntities2 DB = new Entity.db_a4f9ad_stormprEntities2();

        public void cadastrar(Entity.tb_aula agenda)
        {
            DB.tb_aula.Add(agenda);
            DB.SaveChanges();
        }

        public List<Entity.tb_aula> ListarTodos()
        {
            List<Entity.tb_aula> agenda = DB.tb_aula.ToList();
            return agenda;
        }

       public List<Entity.tb_aula> ListarPorData(DateTime data)
        {
           List<Entity.tb_aula> agenda = DB.tb_aula.Where(T => T.dt_aula == data)
                                                                     .ToList();
            return agenda;
        }

        public Entity.tb_aula validaFuncionario (Entity.tb_aula aula)
        {

            Entity.tb_aula confirmacao = DB.tb_aula.FirstOrDefault(t => t.dt_aula == aula.dt_aula
                                                                     && t.hr_incio == aula.hr_incio
            && t.id_funcionario == aula.id_funcionario);

            return confirmacao;
        }

        public Entity.tb_aula validaCliente(Entity.tb_aula aula)
        {

            Entity.tb_aula confirmacao = DB.tb_aula.FirstOrDefault(t => t.dt_aula == aula.dt_aula
                                                                     && t.hr_incio == aula.hr_incio
                                                                     && t.id_cliente == aula.id_cliente);

            return confirmacao;
        }

        public Entity.tb_aula validaSala(Entity.tb_aula aula)
        {

            Entity.tb_aula confirmacao = DB.tb_aula.FirstOrDefault(t => t.dt_aula == aula.dt_aula
                                                                     && t.hr_incio == aula.hr_incio
                                                                     && t.id_sala == aula.id_sala);
                
            return confirmacao;
        }

        public Entity.tb_aula validarContrato(Entity.tb_aula aula)
        {
            
            Entity.tb_aula confirmacao = DB.tb_aula.FirstOrDefault(t => t.dt_aula == aula.dt_aula
                                                                     && t.hr_incio == aula.hr_incio
                                                                     );

            return confirmacao;
        }

        public void alterar(Entity.tb_aula agenda)
        {
            Entity.tb_aula NovaAula = DB.tb_aula.FirstOrDefault(t => t.id_aula == agenda.id_aula);

            NovaAula.dt_aula = agenda.dt_aula;
            NovaAula.hr_incio = agenda.hr_incio;
            NovaAula.tp_aula = agenda.tp_aula;
            NovaAula.id_cliente = agenda.id_cliente;
            NovaAula.id_funcionario = agenda.id_funcionario;
            NovaAula.hr_fim = agenda.hr_fim;

            DB.SaveChanges();
        }

        public void excluir(int id)
        {
            Entity.tb_aula agenda = DB.tb_aula.FirstOrDefault(t => t.id_aula == id);

            DB.tb_aula.Remove(agenda);
            DB.SaveChanges();
        }

       
    }
}
