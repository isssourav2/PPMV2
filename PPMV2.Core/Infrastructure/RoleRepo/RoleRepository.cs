using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RoleRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.UserRepo;

namespace PPMV2.Core.Infrastructure.RoleRepo
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly IUserRepository _userRepository;
        public RoleRepository(IUserRepository userRepository)
        {
            this._userRepository= userRepository;
        }
        public async Task<IEnumerable<Role>> GetWithUserCount()
        {
            List<Role> roles = new List<Role>();
            var Roles =await this.GetAll();
            foreach (var role in Roles)
            {
                role.userCount = this._userRepository.GetAll().Result.Where(x=>x.RoleId== role.RoleId).Count();
                roles.Add(role);
            }
            return roles;
        }
    }
}
