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
    
    public partial class tb_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente()
        {
            this.tb_agenda_estudio = new HashSet<tb_agenda_estudio>();
            this.tb_aula = new HashSet<tb_aula>();
            this.tb_venda_plano = new HashSet<tb_venda_plano>();
        }
    
        public int id_cliente { get; set; }
        public string nm_cliente { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public string ds_telefone { get; set; }
        public string ds_email { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public string ds_cep { get; set; }
        public string ds_observacao { get; set; }
        public string ds_estado { get; set; }
        public string ds_bairro { get; set; }
        public string ds_periodo { get; set; }
        public string nm_responsavel { get; set; }
        public string ds_nivel { get; set; }
        public int nmr_cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_agenda_estudio> tb_agenda_estudio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_aula> tb_aula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda_plano> tb_venda_plano { get; set; }
    }
}
