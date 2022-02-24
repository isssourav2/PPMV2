using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FileProcessingTemplateFormulaFieldRepo
{
    public interface IFileProcessingTemplateFormulaFieldRepository:IRepository<FileProcessingTemplateFormulaField>
    {
        Task<IEnumerable<FileProcessingTemplateFormulaField>> GetAll();
        Task<FileProcessingTemplateFormulaField> GetById(int id);

        Task Add(FileProcessingTemplateFormulaField entity);

        Task Update(FileProcessingTemplateFormulaField entity);

        Task Delete(FileProcessingTemplateFormulaField entity);
    }
}
