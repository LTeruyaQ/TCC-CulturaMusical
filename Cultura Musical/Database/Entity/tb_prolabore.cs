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
    
    public partial class tb_prolabore
    {
        public int id_prolabore { get; set; }
        public string nm_prolabore { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public string nmr_telefone { get; set; }
        public string ds_email { get; set; }
        public string ds_bairro { get; set; }
        public string ds_rua { get; set; }
        public string ds_cidade { get; set; }
        public string ds_estado { get; set; }
        public string ds_cep { get; set; }
        public string ds_genero { get; set; }
        public int id_login { get; set; }
    
        public virtual tb_login tb_login { get; set; }
    }
}
