using PPMV2.Core.Infrastructure.FileProcessingTemplateRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FileProcessingTemplateFormulaField:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FileProcessingTemplateId { get; set; }
        public string FormulaFieldName { get; set; }
        public string FormulaFieldDescription { get; set; }
        public string Formula { get; set; }
        public bool Enabled { get; set; }
       // public virtual FileProcessingTemplate FileProcessingTemplate { get; set; }
      
    }
}
