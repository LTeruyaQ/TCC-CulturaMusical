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
            this.validacao(plano);

            Database.Entity.tb_plano procura = this.ProcurarPlano(plano);

            if (plano.nm_plano == procura.nm_plano)
                throw new ArgumentException("Este nome já esta em uso por outro plano");

            db.CadastrarNovoTipoDePlano(plano);
        }
        public List<Database.Entity.tb_plano> Plano ()
        {
            
            List<Database.Entity.tb_plano> lista = db.ListarTodos();

            return lista;
        }   

        public void Altera (Database.Entity.tb_plano plano)
        {
            this.validacao(plano);
            db.Alterar(plano);
        }

        public Database.Entity.tb_plano ProcurarPlano (Database.Entity.tb_plano plano)
        {
            return db.ProcurarPlano(plano);
        }

        public void Deletar (Database.Entity.tb_plano plano)
        {
            db.Excluir(plano.id_plano);
        }

        private void validacao (Database.Entity.tb_plano plano)
        {

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

        public bool verificar(string nome)
        {
            Database.Entity.tb_plano plano = db.verificar(nome);

            bool ver = true;
            if (plano == null)
            {
                ver = false;
            }
            return ver;
        }



    }
}
