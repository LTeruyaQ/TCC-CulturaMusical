//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cultura_Musical.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_tipo_conta
    {
        public tb_tipo_conta()
        {
            this.tb_conta = new HashSet<tb_conta>();
        }
    
        public int id_tipo_conta { get; set; }
        public string conta { get; set; }
    
        public virtual ICollection<tb_conta> tb_conta { get; set; }
    }
}
