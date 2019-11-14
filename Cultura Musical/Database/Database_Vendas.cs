using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Vendas
    {

        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();
        //Entity.db_a4f9ad_stormprEntities2 DB = new Entity.db_a4f9ad_stormprEntities2();


        public void CadastrarNovoTipoDePlano(Entity.tb_venda_plano venda)
        {
            DB.tb_venda_plano.Add(venda);
            DB.SaveChanges();
        }

        public List<Entity.tb_venda_plano> ListarTodos()
        {
            List<Entity.tb_venda_plano> vendas = DB.tb_venda_plano.ToList();
            return vendas;
        }

        public void Alterar(Entity.tb_venda_plano vendas)
        {
            Entity.tb_venda_plano NovaVenda = DB.tb_venda_plano.FirstOrDefault(t => t.id_venda_plano == vendas.id_venda_plano);

            NovaVenda.dt_inicio = vendas.dt_inicio;
            NovaVenda.dt_fim = vendas.dt_fim;
            NovaVenda.id_cliente = vendas.id_cliente;
            NovaVenda.id_plano = vendas.id_plano;
          
            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_venda_plano vendas = DB.tb_venda_plano.FirstOrDefault(t => t.id_venda_plano == id);

            DB.tb_venda_plano.Remove(vendas);
            DB.SaveChanges();
        }
    }
}
