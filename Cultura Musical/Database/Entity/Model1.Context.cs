﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cultura_Musical.Database.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cultura_musicalEntities : DbContext
    {
        public cultura_musicalEntities()
            : base("name=cultura_musicalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tb_cliente> tb_cliente { get; set; }
        public DbSet<tb_cliente_aula> tb_cliente_aula { get; set; }
        public DbSet<tb_colaborador> tb_colaborador { get; set; }
        public DbSet<tb_conta> tb_conta { get; set; }
        public DbSet<tb_folha_pagamento> tb_folha_pagamento { get; set; }
        public DbSet<tb_fornecedor> tb_fornecedor { get; set; }
        public DbSet<tb_funcionario> tb_funcionario { get; set; }
        public DbSet<tb_login> tb_login { get; set; }
        public DbSet<tb_pedido_compra> tb_pedido_compra { get; set; }
        public DbSet<tb_pedido_compra_item> tb_pedido_compra_item { get; set; }
        public DbSet<tb_plano> tb_plano { get; set; }
        public DbSet<tb_produto_compra> tb_produto_compra { get; set; }
        public DbSet<tb_tipo_conta> tb_tipo_conta { get; set; }
        public DbSet<tb_venda_plano> tb_venda_plano { get; set; }
        public DbSet<tb_venda_produto> tb_venda_produto { get; set; }
    }
}
