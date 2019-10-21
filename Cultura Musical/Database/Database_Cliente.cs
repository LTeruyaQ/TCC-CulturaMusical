using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Cliente
    {
        Entity.culturamusicalEntities DB = new Entity.culturamusicalEntities();

        public void cadastrar(Entity.tb_cliente cliente)
        {
            DB.tb_cliente.Add(cliente);
            DB.SaveChanges();
        }

        public List<Entity.tb_cliente> ListarTodos()
        {
            List<Entity.tb_cliente> cliente = DB.tb_cliente.ToList();
            return cliente;
        }

        public List<Entity.tb_cliente> ListarPorNome(string nome)
        {
            List<Entity.tb_cliente> cliente = DB.tb_cliente.Where(T => T.nm_cliente.Contains(nome))
                                                                      .ToList();
            return cliente;
        }

        public void alterar(Entity.tb_cliente cliente)
        {
            Entity.tb_cliente NovoCliente = DB.tb_cliente.FirstOrDefault(t => t.id_cliente == cliente.id_cliente);

            NovoCliente.nm_cliente = cliente.nm_cliente;
            NovoCliente.ds_idade = cliente.ds_idade;
            NovoCliente.ds_telefone = cliente.ds_telefone;
            NovoCliente.ds_cep = cliente.ds_cep;
            NovoCliente.ds_bairro = cliente.ds_bairro;
            NovoCliente.ds_cpf = cliente.ds_cpf;
            NovoCliente.ds_email = cliente.ds_email;
            NovoCliente.ds_nivel = cliente.ds_nivel;
            NovoCliente.ds_periodo = cliente.ds_periodo;
            NovoCliente.ds_rg = cliente.ds_rg;
            NovoCliente.ds_observacao = cliente.ds_observacao;

                DB.SaveChanges();
        }

        public void excluir(int id)
        {
            Entity.tb_cliente cliente = DB.tb_cliente.FirstOrDefault(t => t.id_cliente == id);

            DB.tb_cliente.Remove(cliente);
            DB.SaveChanges();
        }
    }
}
