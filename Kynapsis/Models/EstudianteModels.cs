using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kynapsis.Models
{
    public class Estudiante
    {
        [Key()]
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }

    }




}