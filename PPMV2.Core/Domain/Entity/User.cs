using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Domain.Entity
{
    public class User
    {
        public System.Guid? UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int RoleId { get; set; }
        [NotMapped]
        public string RoleName { get; set; }
        public bool IsActive { get; set; } 
        public DateTime EntryDate { get; set; } 
        public DateTime? UpdateDate { get; set; }

    }
}
