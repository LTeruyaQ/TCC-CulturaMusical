//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_venda_produto
    {
        public int id_produto_venda { get; set; }
        public string nm_produto { get; set; }
        public decimal vl_produto { get; set; }
        public int qtd_produto { get; set; }
        public int id_produto { get; set; }
        public int id_cliente { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        public virtual tb_produto_compra tb_produto_compra { get; set; }
    }
}
