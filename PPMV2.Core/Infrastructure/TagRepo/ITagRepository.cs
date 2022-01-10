using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;

namespace PPMV2.Core.Infrastructure.TagRepo
{
    public interface ITagRepository : IRepository<Tag>
    {
        Task<IEnumerable<Tag>> GetAll();
        Task<Tag> GetById(int id);

        Task Add(Tag entity);

        Task Update(Tag entity);

        Task Delete(Tag entity);
    }
}
