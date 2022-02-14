using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FileReadingIndentification
{
    public interface IFileReadRepository : IRepository<FileRead>
    {
        Task<IEnumerable<FileRead>> GetAll();
        Task<FileRead> GetById(int id);

        Task Add(FileRead entity);

        Task Update(FileRead entity);

        Task Delete(FileRead entity);
    }
}
