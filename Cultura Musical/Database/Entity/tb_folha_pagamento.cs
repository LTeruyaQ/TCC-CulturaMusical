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
    
    public partial class tb_folha_pagamento
    {
        public int id_folha { get; set; }
        public decimal vl_salario_bruto { get; set; }
        public decimal vl_salario_liquido { get; set; }
        public int id_funcionario { get; set; }
        public int id_financeiro { get; set; }
        public System.DateTime dt_folha { get; set; }
        public System.TimeSpan hr_extra { get; set; }
    
        public virtual tb_financeiro tb_financeiro { get; set; }
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}
