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
    
    public partial class tb_cliente_aula
    {
        public int id_aula { get; set; }
        public System.DateTime dt_aula { get; set; }
        public System.TimeSpan hr_aula { get; set; }
        public string tp_aula { get; set; }
        public int nr_sala { get; set; }
        public int id_funcionario { get; set; }
        public int id_cliente { get; set; }
    
        public virtual tb_cliente tb_cliente { get; set; }
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}
