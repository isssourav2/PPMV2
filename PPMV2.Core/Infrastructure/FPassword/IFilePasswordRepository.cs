using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FPassword
{
    public interface IFilePasswordRepository : IRepository<FilePassword>
    {
        Task<IEnumerable<FilePassword>> GetAll();
        Task<FilePassword> GetById(int id);

        Task Add(FilePassword entity);

        Task Update(FilePassword entity);

        Task Delete(FilePassword entity);
    }
}
