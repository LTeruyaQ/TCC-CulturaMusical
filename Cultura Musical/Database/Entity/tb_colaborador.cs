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
    
    public partial class tb_colaborador
    {
        public int id_funcionario { get; set; }
        public string nm_funcionario { get; set; }
        public int ds_rg { get; set; }
        public int ds_cpf { get; set; }
        public Nullable<int> ds_cep { get; set; }
        public string ds_endereco { get; set; }
        public Nullable<System.DateTime> dt_nascimento { get; set; }
        public Nullable<System.DateTime> dt_contratacao { get; set; }
        public Nullable<System.DateTime> dt_demicao { get; set; }
        public Nullable<decimal> vl_salario { get; set; }
        public Nullable<int> ds_falta { get; set; }
        public Nullable<int> ds_telefone { get; set; }
        public string ds_email { get; set; }
        public string genero_funcionario { get; set; }
    }
}
