using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDescription { get; set; }

        public DateTime EntryDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
