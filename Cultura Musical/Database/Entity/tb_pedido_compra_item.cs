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
    
    public partial class tb_pedido_compra_item
    {
        public int id_pedido_compra_item { get; set; }
        public int id_pedido_compra { get; set; }
        public int id_produto { get; set; }
    
        public virtual tb_pedido_compra tb_pedido_compra { get; set; }
        public virtual tb_produto_compra tb_produto_compra { get; set; }
    }
}
