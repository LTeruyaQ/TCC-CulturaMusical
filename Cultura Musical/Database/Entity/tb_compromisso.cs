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
    
    public partial class tb_compromisso
    {
        public tb_compromisso()
        {
            this.tb_agenda_all = new HashSet<tb_agenda_all>();
        }
    
        public int id_compromisso { get; set; }
        public System.DateTime dt_dia { get; set; }
        public System.TimeSpan hr_inicio { get; set; }
        public System.TimeSpan hr_final { get; set; }
        public int id_cliente { get; set; }
        public int sala { get; set; }
    
        public virtual ICollection<tb_agenda_all> tb_agenda_all { get; set; }
    }
}
