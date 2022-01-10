using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;

namespace PPMV2.Core.Infrastructure.RoleRepo
{
    public interface IRoleRepository : IRepository<Role>
    {
        Task<IEnumerable<Role>> GetAll();
        Task<Role> GetById(int id);

        Task Add(Role entity);

        Task Update(Role entity);

        Task Delete(Role entity);
    }
}
