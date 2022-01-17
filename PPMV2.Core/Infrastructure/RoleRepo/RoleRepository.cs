using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RoleRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.UserRepo;
using PPMV2.Core.Infrastructure.MenuwithRoleRepo;

namespace PPMV2.Core.Infrastructure.RoleRepo
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        private readonly IUserRepository _userRepository;
        private readonly IMenuwithRoleRepository _menuwithRoleRepository;
        public RoleRepository(IUserRepository userRepository, IMenuwithRoleRepository menuwithRoleRepository)
        {
            this._userRepository= userRepository;
            this._menuwithRoleRepository = menuwithRoleRepository;
        }
        public async Task<IEnumerable<Role>> GetWithUserCount()
        {
            List<Role> roles = new List<Role>();
            var Roles =await this.GetAll();
            foreach (var role in Roles)
            {
                role.userCount = this._userRepository.GetAll().Result.Where(x=>x.RoleId== role.RoleId).Count();
                role.PermissionCount=this._menuwithRoleRepository.GetAll().Result.Where(x => x.RoleId == role.RoleId).Count();
                roles.Add(role);
            }
            return roles;
        }
    }
}
