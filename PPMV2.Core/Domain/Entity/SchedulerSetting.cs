using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class SchedulerSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public decimal? TimeInterval { get;set; }

        //common part
        public DateTime? EntryDate { get; set; }
        public Guid? EntryBy { get; set; }

        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateBy { get; set; }
    }
}
