
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
    
public partial class tb_jornada
{

    public int id_jornada { get; set; }

    public int id_funcionario { get; set; }

    public Nullable<int> tot_faltas { get; set; }



    public virtual tb_funcionario tb_funcionario { get; set; }

}

}
