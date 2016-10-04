using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kynapsis.Models
{
    public class ErrorModel
    {
        public int HttpStatusCode { get; set; }

        public Exception Exception { get; set; }
    }

}
