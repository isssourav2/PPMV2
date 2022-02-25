using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FProcessingTemplateTagMapping
{
    public interface IFileProcessingTemplateTagMappingRepository : IRepository<FileProcessingTemplateTagMapping>
    {
        Task<IEnumerable<FileProcessingTemplateTagMapping>> GetAll();
        Task<FileProcessingTemplateTagMapping> GetById(int id);

        Task Add(FileProcessingTemplateTagMapping entity);

        Task Update(FileProcessingTemplateTagMapping entity);

        Task Delete(FileProcessingTemplateTagMapping entity);
    }
}
