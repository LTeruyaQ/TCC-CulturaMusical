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
    
    public partial class tb_colaborador
    {
        public int id_colaborador { get; set; }
        public string nm_colaborador { get; set; }
        public System.DateTime nascimento { get; set; }
        public System.DateTime contratacao { get; set; }
        public System.DateTime demicao { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
    }
}
