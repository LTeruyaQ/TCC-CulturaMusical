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
    }
}
