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
    
    public partial class tb_login
    {
        public int id_login { get; set; }
        public string nm_usuario { get; set; }
        public string sen_usuario { get; set; }
        public System.DateTime dt_login { get; set; }
        public int nv_login { get; set; }
        public int id_funcionario { get; set; }
    
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}
