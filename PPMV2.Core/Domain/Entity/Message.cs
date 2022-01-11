using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class Message
    {
        public string message { get; set; }

        public string Status { get; set; }

        public int? Count { get; set; }
    }
}
