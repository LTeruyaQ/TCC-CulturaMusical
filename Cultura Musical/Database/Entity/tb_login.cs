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
        public tb_login()
        {
            this.tb_funcionario = new HashSet<tb_funcionario>();
        }
    
        public int id_login { get; set; }
        public string nm_usuario { get; set; }
        public string sen_usuario { get; set; }
        public System.DateTime login { get; set; }
    
        public virtual ICollection<tb_funcionario> tb_funcionario { get; set; }
    }
}
