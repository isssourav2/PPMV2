using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.FProcessingTemplateDMSApplication
{
    public interface IFileProcessingTemplateDMSApplicationRepository : IRepository<FileProcessingTemplateDMSApplication>
    {
        Task<IEnumerable<FileProcessingTemplateDMSApplication>> GetAll();
        Task<FileProcessingTemplateDMSApplication> GetById(int id);

        Task Add(FileProcessingTemplateDMSApplication entity);

        Task Update(FileProcessingTemplateDMSApplication entity);

        Task Delete(FileProcessingTemplateDMSApplication entity);
    }
}
