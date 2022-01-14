using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class RoleMenuMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<int> MenuId { get; set; }
        //[ForeignKey("MenuId")]
        //public virtual MenuMaster MenuMaster { get; set; }
        //public virtual Role Role { get; set; }
    }
}
    