using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FundScheduler : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int FileProcessingTemplateId { get; set; }
        public int FrequencyTagId { get; set; }
        public int AsAt { get; set; }
        public int FromTo { get; set; }
        public int FromToRange { get; set; }
        public string? Note { get; set; }
    }
    }
