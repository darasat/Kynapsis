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
    
    public partial class CitaIndividual
    {
        public int IdCita { get; set; }
        public string NumeroOrden { get; set; }
        public string Fisioterapeuta { get; set; }
        public string Paciente { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
    
        public virtual Fisioterapeuta Fisioterapeuta1 { get; set; }
        public virtual Orden Orden { get; set; }
    }
}
