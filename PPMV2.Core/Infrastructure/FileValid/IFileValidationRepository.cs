using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FileValid
{
    public interface IFileValidationRepository : IRepository<FileValidation>
    {
        Task<IEnumerable<FileValidation>> GetAll();
        Task<FileValidation> GetById(int id);

        Task Add(FileValidation entity);

        Task Update(FileValidation entity);

        Task Delete(FileValidation entity);
    }
}
