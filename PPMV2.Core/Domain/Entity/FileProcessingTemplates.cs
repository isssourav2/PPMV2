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
        public FileProcessingTemplates()
        {
            Tags = new List<Tag>();
            Applications = new List<Application>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? RiskCoreImportTemplateId { get; set; }

        public string FileProcessingTemplateName { get; set; }
        public string CSVDelimiter { get; set; }
        public string TextDelimiter { get; set; }
        public string PreprocessedDeliveryPath { get; set; }
        public string? Username { get; set; }

        public string? Password { get; set; }

        public Boolean IsManipulation { get; set; }

        public int TagId { get; set; }
        public int ApplicationId { get; set; }
        [NotMapped]
        public List<Tag> Tags { get; set; }
        [NotMapped]
        public List<Application> Applications { get; set; }
        //public List<Tag> Tags { get; set; }
        //public List<Application> Applications { get; set; }
        [NotMapped]
        public string? RiskCoreTemplate { get; set; }
        public int RiskCoreTemplateId { get; set; }
    }
}
