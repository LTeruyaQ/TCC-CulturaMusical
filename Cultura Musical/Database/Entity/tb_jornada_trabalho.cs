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
    
    public partial class tb_jornada_trabalho
    {
        public tb_jornada_trabalho()
        {
            this.tb_funcionario = new HashSet<tb_funcionario>();
            this.tb_jornada = new HashSet<tb_jornada>();
        }
    
        public int id_jornada_trabalho { get; set; }
    
        public virtual ICollection<tb_funcionario> tb_funcionario { get; set; }
        public virtual ICollection<tb_jornada> tb_jornada { get; set; }
    }
}
