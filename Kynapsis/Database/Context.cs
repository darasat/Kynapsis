using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kynapsis.Models
{
    public class KynapsisDBContext : DbContext
    {

        public KynapsisDBContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}