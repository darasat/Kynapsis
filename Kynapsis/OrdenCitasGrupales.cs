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
    public partial class OrdenCitasGrupales
    {
        [Key]
        public int Cita { get; set; }
        public string Orden { get; set; }
    
        public virtual CitaGrupal CitaGrupal { get; set; }
        public virtual Orden Orden1 { get; set; }
    }
}