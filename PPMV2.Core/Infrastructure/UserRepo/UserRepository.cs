using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.UserRepo
{
    public class UserRepository: Repository<User>,IUserRepository
    {
        public Message GetUserCountByRoleId(int roleid)
        {
            Message mes=new Message();
            mes.Count=  this.entity.Where(x=>x.RoleId==roleid).ToList().Count();
            mes.message = "User_count";
            mes.Status = "";
            return mes;
        }
    }
}
