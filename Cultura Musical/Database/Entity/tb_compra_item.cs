//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_compra_item
    {
        public int id_compra_item { get; set; }
        public int tb_compra_id_compra { get; set; }
        public int tb_produto_compra_id_produto_compra { get; set; }
    
        public virtual tb_compra tb_compra { get; set; }
        public virtual tb_produto_compra tb_produto_compra { get; set; }
    }
}
