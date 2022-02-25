using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FileFetch : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FileProcessingTemplateId { get; set; }
        public int ConnectionId { get; set; }
        public string SourcePathFormat { get; set; }
        public string FileName { get; set; }
        public string ReceivedFrom { get; set; }
        public string SubjectHeader { get; set; }
        public string SentTo { get; set; }
    }
}
