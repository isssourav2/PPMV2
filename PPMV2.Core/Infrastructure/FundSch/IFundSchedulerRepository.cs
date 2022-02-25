using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FundSch
{
    public interface IFundSchedulerRepository : IRepository<FundScheduler>
    {
        Task<IEnumerable<FundScheduler>> GetAll();
        Task<FundScheduler> GetById(int id);

        Task Add(FundScheduler entity);

        Task Update(FundScheduler entity);

        Task Delete(FundScheduler entity);
    }
}
