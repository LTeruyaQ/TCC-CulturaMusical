
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
    
public partial class tb_venda_plano
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public tb_venda_plano()
    {

        this.tb_aula = new HashSet<tb_aula>();

    }


    public int id_venda_plano { get; set; }

    public int id_plano { get; set; }

    public int id_cliente { get; set; }

    public System.DateTime dt_inicio { get; set; }

    public System.DateTime dt_fim { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<tb_aula> tb_aula { get; set; }

    public virtual tb_cliente tb_cliente { get; set; }

    public virtual tb_plano tb_plano { get; set; }

}

}
