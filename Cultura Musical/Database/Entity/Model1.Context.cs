﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cultura_Musical.Database.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mydbEntities2 : DbContext
    {
        public mydbEntities2()
            : base("name=mydbEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tb_beneficio> tb_beneficio { get; set; }
        public DbSet<tb_cliente> tb_cliente { get; set; }
        public DbSet<tb_cliente_aula> tb_cliente_aula { get; set; }
        public DbSet<tb_compra> tb_compra { get; set; }
        public DbSet<tb_compra_item> tb_compra_item { get; set; }
        public DbSet<tb_conta> tb_conta { get; set; }
        public DbSet<tb_estoque> tb_estoque { get; set; }
        public DbSet<tb_financeiro> tb_financeiro { get; set; }
        public DbSet<tb_folha_pagamento> tb_folha_pagamento { get; set; }
        public DbSet<tb_fornecedor> tb_fornecedor { get; set; }
        public DbSet<tb_funcionario> tb_funcionario { get; set; }
        public DbSet<tb_holerite> tb_holerite { get; set; }
        public DbSet<tb_jornada> tb_jornada { get; set; }
        public DbSet<tb_login> tb_login { get; set; }
        public DbSet<tb_plano> tb_plano { get; set; }
        public DbSet<tb_produto_compra> tb_produto_compra { get; set; }
        public DbSet<tb_sala> tb_sala { get; set; }
        public DbSet<tb_tipo_conta> tb_tipo_conta { get; set; }
        public DbSet<tb_venda_plano> tb_venda_plano { get; set; }
    }
}
