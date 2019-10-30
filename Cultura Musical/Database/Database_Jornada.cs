using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Jornada
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();
        public void InserirJornada (Entity.tb_jornada Jornada)
        {
            DB.tb_jornada.Add(Jornada);
            DB.SaveChanges();
        }

        public void Alterar (Database.Entity.tb_jornada jornada)
        {
            Database.Entity.tb_jornada NovaJornada = DB.tb_jornada.FirstOrDefault(t => t.id_funcionario == jornada.id_funcionario);

            NovaJornada.hr_entrada = jornada.hr_entrada;
            NovaJornada.hr_intervalo = jornada.hr_intervalo;
            NovaJornada.hr_saida = jornada.hr_saida;
            NovaJornada.hr_volta_intervalo = jornada.hr_volta_intervalo;

            DB.SaveChanges();

        }

        public void Deletar (int id)
        {
            Database.Entity.tb_jornada Deletada = DB.tb_jornada.FirstOrDefault(t => t.id_jornada == id);

            DB.tb_jornada.Remove(Deletada);
        }

        public List<Database.Entity.tb_jornada> ListarTodos ()
        {
            List<Database.Entity.tb_jornada> Jornadas = DB.tb_jornada.ToList();
            return Jornadas;
        }

        public Database.Entity.tb_jornada Procurar(Database.Entity.tb_jornada jornada)
        {
            Database.Entity.tb_jornada Procura = DB.tb_jornada.FirstOrDefault(t => t.id_funcionario == jornada.id_funcionario);

            return Procura;

        }
    }
}
