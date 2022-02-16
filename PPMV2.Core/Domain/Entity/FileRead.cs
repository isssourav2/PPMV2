using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class FileRead : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public FileProcessingTemplates FileProcessingTemplate { get; set; }

        public string BasedOn { get; set; }

        public string CheckIn { get; set; }

        public string CellOrHeader { get; set; }

        public string CellOrHeaderValue { get; set; }

        public string Operation { get; set; }

        public string SearchValue { get; set; }

        public string ReadFromNextColCell { get; set; }

        public string SheetName { get; set; }
    }
}
