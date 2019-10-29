using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Planos
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();


        public void CadastrarNovoTipoDePlano(Entity.tb_plano plano)
        {
            DB.tb_plano.Add(plano);
            DB.SaveChanges();
        }

        public List<Entity.tb_plano> ListarTodos()
        {
            List<Entity.tb_plano> planos = DB.tb_plano.ToList();
            return planos;
        }

        public List<Entity.tb_plano> ListarPorNome(string nome)
        {
            List<Entity.tb_plano> plano = DB.tb_plano.Where(T => T.nm_plano.Contains(nome))
                                                                      .ToList();
            return plano;
        }

        public void Alterar(Entity.tb_plano plano)
        {
            Entity.tb_plano NovoPlano = DB.tb_plano.FirstOrDefault(t => t.id_plano == plano.id_plano);


            NovoPlano.ds_descricao = plano.ds_descricao;
            NovoPlano.ds_duracao = plano.ds_duracao;
            NovoPlano.nm_plano = plano.nm_plano;
            NovoPlano.vl_preco = plano.vl_preco;
            NovoPlano.qtd_aula_semana = plano.qtd_aula_semana;

            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_plano plano = DB.tb_plano.FirstOrDefault(t => t.id_plano == id);

            DB.tb_plano.Remove(plano);
            DB.SaveChanges();
        }

        public void VendaPlano(Database.Entity.tb_venda_plano plano)
        {
            DB.tb_venda_plano.Add(plano);
            DB.SaveChanges();
        }
    }
}
