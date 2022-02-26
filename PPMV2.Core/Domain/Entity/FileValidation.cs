using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FileValidation : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FileProcessingTemplateId { get; set; }
        public string? ColumnOrder { get; set; }
        public string? ColumnName { get; set; }
        public string? DataType { get; set; }
        //public Nullable<bool> IsNull { get; set; }
        //public virtual FileProcessingTemplates FileProcessingTemplate { get; set; }

    }
}
