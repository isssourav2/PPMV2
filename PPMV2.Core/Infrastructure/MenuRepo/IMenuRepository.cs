using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.MenuRepo
{
   public  interface IMenuRepository : IRepository<MenuMaster>
    {
        Task<IEnumerable<MenuMaster>> GetAll();
        Task<MenuMaster> GetById(int id);

        Task Add(MenuMaster entity);

        Task Update(MenuMaster entity);

        Task Delete(MenuMaster entity);
    }
}
