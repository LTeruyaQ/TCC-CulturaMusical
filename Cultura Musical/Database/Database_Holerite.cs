using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Holerite
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();


        public void Cadastrar(Entity.tb_holerite pagamento)
        {
            DB.tb_holerite.Add(pagamento);
            DB.SaveChanges();
        }

        public List<Entity.tb_holerite> ListarTodos()
        {
            List<Entity.tb_holerite> pagamento = DB.tb_holerite.ToList();
            return pagamento;
        }

        public List<Entity.tb_holerite> ListarPorquantidade(decimal pagamento)
        {
            List<Entity.tb_holerite> holerites = DB.tb_holerite.Where(T => T.salario_bruto == pagamento)
                                                                      .ToList();
            return holerites;
        }

        public void Alterar(Entity.tb_holerite pagamento)
        {
            Entity.tb_holerite Novoholerite = DB.tb_holerite.FirstOrDefault(t => t.id_holerite == pagamento.id_holerite);


            Novoholerite.id_funcionario = pagamento.id_funcionario;
            Novoholerite.falta_mes = pagamento.falta_mes;
            Novoholerite.salario_bruto = pagamento.salario_bruto;
            Novoholerite.salario_liquido = pagamento.salario_liquido;
            Novoholerite.tb_funcionario = pagamento.tb_funcionario;
           


            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_holerite pagamento = DB.tb_holerite.FirstOrDefault(t => t.id_holerite == id);

            DB.tb_holerite.Remove(pagamento);
            DB.SaveChanges();
        }
    }
}
