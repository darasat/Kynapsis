//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kynapsis
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Orden
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orden()
        {
            this.CitaIndividual = new HashSet<CitaIndividual>();
            this.OrdenCitasGrupales = new HashSet<OrdenCitasGrupales>();
        }
        [Key]
        public string NumeroOrden { get; set; }
        public Nullable<int> Sesiones { get; set; }
        public string DocumentoPaciente { get; set; }
        public string TipoOrden { get; set; }
        public Nullable<System.DateTime> FechaOrden { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public string CodigoSiniestro { get; set; }
        public string Ordencol { get; set; }
        public string Dx { get; set; }
        public Nullable<System.DateTime> FechaAccidente { get; set; }
        public string Diagnostico { get; set; }
        public string Cobertura { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CitaIndividual> CitaIndividual { get; set; }
        public virtual Paciente Paciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenCitasGrupales> OrdenCitasGrupales { get; set; }
    }
}