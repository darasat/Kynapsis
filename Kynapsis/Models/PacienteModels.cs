using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kynapsis.Models
{
    public class PacienteModels
    {
        [Key]
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public Nullable<int> Estrato { get; set; }
        public string Correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orden> Orden { get; set; }
    }

    public class KinapsisDBContext : DbContext
    {


        public KinapsisDBContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Paciente> Paciente { get; set; }
    }
}