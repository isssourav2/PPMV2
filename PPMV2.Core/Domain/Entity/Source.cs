using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class Source : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SourceId { get; set; }
        public string SourceName { get; set; }
        public string SourceAddress { get; set; }
        public string SourceEmail { get; set; }
        public string SourcePhone { get; set; }
        public bool IsActive { get; set; }
      
    }
}
