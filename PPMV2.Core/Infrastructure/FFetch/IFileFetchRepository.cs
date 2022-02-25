using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FFetch
{
    public interface IFileFetchRepository : IRepository<FileFetch>
    {
        Task<IEnumerable<FileFetch>> GetAll();
        Task<FileFetch> GetById(int id);

        Task Add(FileFetch entity);

        Task Update(FileFetch entity);

        Task Delete(FileFetch entity);
    }
}
