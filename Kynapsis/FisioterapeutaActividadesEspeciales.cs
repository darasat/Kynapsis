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
    
    public partial class FisioterapeutaActividadesEspeciales
    {
        public int ActividadEspecial { get; set; }
        public string Fisioterapeuta { get; set; }
    
        public virtual Actividades_Especiales Actividades_Especiales { get; set; }
        public virtual Fisioterapeuta Fisioterapeuta1 { get; set; }
    }
}
