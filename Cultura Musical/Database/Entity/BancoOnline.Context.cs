﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Cultura_Musical.Database.Entity
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class db_a4f9ad_stormprEntities : DbContext
{
    public db_a4f9ad_stormprEntities()
        : base("name=db_a4f9ad_stormprEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<tb_agenda_estudio> tb_agenda_estudio { get; set; }

    public virtual DbSet<tb_aula> tb_aula { get; set; }

    public virtual DbSet<tb_beneficio> tb_beneficio { get; set; }

    public virtual DbSet<tb_cliente> tb_cliente { get; set; }

    public virtual DbSet<tb_colaborador> tb_colaborador { get; set; }

    public virtual DbSet<tb_compra> tb_compra { get; set; }

    public virtual DbSet<tb_conta> tb_conta { get; set; }

    public virtual DbSet<tb_estado> tb_estado { get; set; }

    public virtual DbSet<tb_estoque> tb_estoque { get; set; }

    public virtual DbSet<tb_financeiro> tb_financeiro { get; set; }

    public virtual DbSet<tb_folha_pagamento> tb_folha_pagamento { get; set; }

    public virtual DbSet<tb_fornecedor> tb_fornecedor { get; set; }

    public virtual DbSet<tb_holerite> tb_holerite { get; set; }

    public virtual DbSet<tb_jornada> tb_jornada { get; set; }

    public virtual DbSet<tb_login> tb_login { get; set; }

    public virtual DbSet<tb_plano> tb_plano { get; set; }

    public virtual DbSet<tb_ponto> tb_ponto { get; set; }

    public virtual DbSet<tb_produto> tb_produto { get; set; }

    public virtual DbSet<tb_prolabore> tb_prolabore { get; set; }

    public virtual DbSet<tb_sala> tb_sala { get; set; }

    public virtual DbSet<tb_tipo_conta> tb_tipo_conta { get; set; }

    public virtual DbSet<tb_venda_plano> tb_venda_plano { get; set; }

    public virtual DbSet<fluxo_de_caixa> fluxo_de_caixa { get; set; }

    public virtual DbSet<tb_funcionario> tb_funcionario { get; set; }

}

}

