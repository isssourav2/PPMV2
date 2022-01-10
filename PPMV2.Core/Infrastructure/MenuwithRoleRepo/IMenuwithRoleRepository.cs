using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.MenuwithRoleRepo
{
    public interface IMenuwithRoleRepository : IRepository<RoleMenuMapping>
    {
        Task<IEnumerable<RoleMenuMapping>> GetAll();
        Task<RoleMenuMapping> GetById(int id);

        Task Add(RoleMenuMapping entity);

        Task Update(RoleMenuMapping entity);

        Task Delete(RoleMenuMapping entity);
    }
}
