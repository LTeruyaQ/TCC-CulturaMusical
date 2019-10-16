﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Agenda
    {

        Entity.mydbEntities2 DB = new Entity.mydbEntities2();


        public void cadastrar(Entity.tb_cliente_aula agenda)
        {
            DB.tb_cliente_aula.Add(agenda);
            DB.SaveChanges();
        }

        public List<Entity.tb_cliente_aula> ListarTodos()
        {
            List<Entity.tb_cliente_aula> agenda = DB.tb_cliente_aula.ToList();
            return agenda;
        }

       public List<Entity.tb_cliente_aula> ListarPorHorario(DateTime data)
        {
           List<Entity.tb_cliente_aula> agenda = DB.tb_cliente_aula.Where(T => T.dt_aula == data)
                                                                     .ToList();
            return agenda;
        }

        public void alterar(Entity.tb_cliente_aula agenda)
        {
            Entity.tb_cliente_aula NovaAula = DB.tb_cliente_aula.FirstOrDefault(t => t.id_aula == agenda.id_aula);

            NovaAula.dt_aula = agenda.dt_aula;
            NovaAula.hr_aula = agenda.hr_aula;
            NovaAula.tp_aula = agenda.tp_aula;
            NovaAula.id_cliente = agenda.id_cliente;
            NovaAula.id_funcionario = agenda.id_funcionario;

            DB.SaveChanges();
        }

        public void excluir(int id)
        {
            Entity.tb_cliente_aula agenda = DB.tb_cliente_aula.FirstOrDefault(t => t.id_aula == id);

            DB.tb_cliente_aula.Remove(agenda);
            DB.SaveChanges();
        }
    }
}
