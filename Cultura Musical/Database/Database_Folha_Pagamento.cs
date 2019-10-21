using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Folha_Pagamento
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void Cadastrar(Entity.tb_folha_pagamento pagamento)
        {
            DB.tb_folha_pagamento.Add(pagamento);
            DB.SaveChanges();
        }

        public List<Entity.tb_folha_pagamento> ListarTodos()
        {
            List<Entity.tb_folha_pagamento> pagamento = DB.tb_folha_pagamento.ToList();
            return pagamento;
        }

        public List<Entity.tb_folha_pagamento> ListarPorquantidade(decimal pagamento)
        {
            List<Entity.tb_folha_pagamento> holerites = DB.tb_folha_pagamento.Where(T => T.vl_salario_bruto == pagamento)
                                                                      .ToList();
            return holerites;
        }

        public void Alterar(Entity.tb_folha_pagamento pagamento)
        {
            Entity.tb_folha_pagamento Novoholerite = DB.tb_folha_pagamento.FirstOrDefault(t => t.id_folha == pagamento.id_folha);

            Novoholerite.id_funcionario = pagamento.id_funcionario;
            Novoholerite.vl_salario_bruto = pagamento.vl_salario_bruto;
            Novoholerite.vl_salario_liquido = pagamento.vl_salario_liquido;
            Novoholerite.tb_funcionario = pagamento.tb_funcionario;
           
            DB.SaveChanges();
        }

        public void Excluir(int id)
        {
            Entity.tb_folha_pagamento pagamento = DB.tb_folha_pagamento.FirstOrDefault(t => t.id_folha == id);

            DB.tb_folha_pagamento.Remove(pagamento);
            DB.SaveChanges();
        }
    }
}
