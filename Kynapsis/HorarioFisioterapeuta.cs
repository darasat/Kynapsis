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
    public partial class HorarioFisioterapeuta
    {
        [Key]
        public string Fisioterapeuta { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<System.TimeSpan> HoraInicio { get; set; }
        public Nullable<System.TimeSpan> HoraFin { get; set; }
        public Nullable<System.TimeSpan> HoraDescanso { get; set; }
        public Nullable<System.TimeSpan> HoraDescansoFin { get; set; }
        public string IdHorarioFisioterapeuta { get; set; }
    
        public virtual Fisioterapeuta Fisioterapeuta1 { get; set; }
    }
}
