
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Cultura_Musical.Database.Entity
{

using System;
    using System.Collections.Generic;
    
public partial class tb_financeiro
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tb_financeiro()
    {

        this.tb_folha_pagamento = new HashSet<tb_folha_pagamento>();

    }


    public int id_financeiro { get; set; }

    public decimal ds_fgts { get; set; }

    public decimal ds_inss { get; set; }

    public decimal ds_irrf { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tb_folha_pagamento> tb_folha_pagamento { get; set; }

}

}
