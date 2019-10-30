using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Business
{
    class Business_Planos
    {
        Database.Database_Planos db = new Database.Database_Planos();

        public void CadastrarPlano(Database.Entity.tb_plano plano)
        {

        }
        public List<Database.Entity.tb_plano> Plano ()
        {
            
            List<Database.Entity.tb_plano> lista = db.ListarTodos();

            return lista;
        }   

        public Database.Entity.tb_plano ProcurarPlano (Database.Entity.tb_plano plano)
        {
            return db.ProcurarPlano(plano);
        }

        public void validacao (Database.Entity.tb_plano plano)
        {
            thi

            if (plano.ds_descricao == string.Empty)
                throw new ArgumentException("É necessario dar uma ao descrição");

            else if (plano.ds_duracao == 0)
                throw new ArgumentException("É necessario informar a duração do plano");

            else if (plano.nm_plano == string.Empty)
                throw new ArgumentException("É necessario atribuir um nome ao plano");

            else if (plano.qtd_aula_semana == 0)
                throw new ArgumentException("É necessario informar a quantidade de aulas por semana");

            else if (plano.vl_preco == 0)
                throw new ArgumentException("É necessario atribuir um valor valido ao plano");
        }

         
    }
}
