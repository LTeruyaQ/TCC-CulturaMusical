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
    
    public partial class tb_dia_semana
    {
        public tb_dia_semana()
        {
            this.tb_escala = new HashSet<tb_escala>();
        }
    
        public int id_dia_semana { get; set; }
        public bool d_segunda { get; set; }
        public bool d_terca { get; set; }
        public bool d_quarta { get; set; }
        public bool d_quinta { get; set; }
        public bool d_sexta { get; set; }
        public bool d_sabado { get; set; }
        public bool d_domingo { get; set; }
    
        public virtual ICollection<tb_escala> tb_escala { get; set; }
    }
}