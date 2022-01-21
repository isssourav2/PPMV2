using PPMV2.Core.Infrastructure.Interface;
using PPMV2.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.SourceRepo
{
    public interface ISourceRepository : IRepository<Source>
    {
        Task<IEnumerable<Source>> GetAll();

        Task<Source> GetById(int id);
        Task Add(Source entity);

        Task Update(Source entity);

        Task Delete(Source entity);
    }
}
