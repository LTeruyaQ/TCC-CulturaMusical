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
    
    public partial class tb_horario
    {
        public tb_horario()
        {
            this.tb_escala = new HashSet<tb_escala>();
        }
    
        public int id_horario { get; set; }
        public System.TimeSpan hr_entrada { get; set; }
        public System.TimeSpan hr_almoco { get; set; }
        public System.TimeSpan hr_retorno { get; set; }
        public System.TimeSpan hr_saida { get; set; }
    
        public virtual ICollection<tb_escala> tb_escala { get; set; }
    }
}
