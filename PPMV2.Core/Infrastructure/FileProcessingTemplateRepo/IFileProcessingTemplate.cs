using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FileProcessingTemplateRepo
{
    public interface IFileProcessingTemplate : IRepository<FileProcessingTemplates>
    {
        Task<IEnumerable<FileProcessingTemplates>> GetAll();
        Task<FileProcessingTemplates> GetById(int id);

        Task Add(FileProcessingTemplates entity);

        Task Update(FileProcessingTemplates entity);

        Task Delete(FileProcessingTemplates entity);
    }
}
