//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cultura_Musical.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_compra
    {
        public int id_compra { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }
        public int id_fornecedor { get; set; }
        public System.DateTime dt_compra { get; set; }
    
        public virtual tb_fornecedor tb_fornecedor { get; set; }
    }
}
