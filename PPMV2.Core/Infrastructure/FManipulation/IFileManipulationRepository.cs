using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FManipulation
{
    public interface IFileManipulationRepository : IRepository<FileManipulation>
    {
        Task<IEnumerable<FileManipulation>> GetAll();
        Task<FileManipulation> GetById(int id);

        Task Add(FileManipulation entity);

        Task Update(FileManipulation entity);

        Task Delete(FileManipulation entity);
    }
}
