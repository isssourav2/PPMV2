using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FileProcessingTemplates : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string JobName { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Application> Applications { get; set; }
        public int RiskCoreTemplateId { get; set; }
    }
}
