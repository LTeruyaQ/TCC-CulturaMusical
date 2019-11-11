using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Financeiro
    {
        //Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        Entity.db_a4f9ad_stormprEntities1 DB = new Entity.db_a4f9ad_stormprEntities1();

        public void InserirFinanceir (Database.Entity.tb_financeiro financeiro)
        {
            DB.tb_financeiro.Add(financeiro);
            DB.SaveChanges();
        }

        public void Alterar (Database.Entity.tb_financeiro financeiro)
        {
            Database.Entity.tb_financeiro NovoFinanceiro = DB.tb_financeiro.FirstOrDefault(t => t.id_financeiro == financeiro.id_financeiro);

            NovoFinanceiro.ds_fgts = financeiro.ds_fgts;
            NovoFinanceiro.ds_inss = financeiro.ds_inss;
            NovoFinanceiro.ds_irrf = financeiro.ds_irrf;

            DB.SaveChanges();
        }

        public void excluir (int id)
        {
            Entity.tb_financeiro remover = DB.tb_financeiro.FirstOrDefault(t => t.id_financeiro == id);

            DB.tb_financeiro.Remove(remover);
            DB.SaveChanges();
        }

        public Entity.tb_financeiro Procurar(Entity.tb_financeiro financeiro)
        {
            Entity.tb_financeiro Procura = DB.tb_financeiro.FirstOrDefault(t => t.id_financeiro == financeiro.id_financeiro);

            return Procura;
        }
    }
}
