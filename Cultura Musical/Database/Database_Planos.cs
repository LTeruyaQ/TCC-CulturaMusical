﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database
{
    class Database_Planos
    {
        Entity.db_a4f9ad_stormprEntities DB = new Entity.db_a4f9ad_stormprEntities();

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

        public Database.Entity.tb_plano ProcurarPlano(Database.Entity.tb_plano plano)
        {
            Database.Entity.tb_plano Procura = DB.tb_plano.FirstOrDefault(t => t.nm_plano == plano.nm_plano
                                                                           && t.ds_descricao == plano.ds_descricao);

            return Procura;
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

        public List<Entity.tb_plano> ProcurarPlanoNome(string nome)
        {
            int tamanho = nome.Length;
            List<Entity.tb_plano> Procura = DB.tb_plano.Where(t => t.nm_plano.Substring(1, tamanho).Contains(nome)).ToList();

            return Procura;
        }

    }
}
