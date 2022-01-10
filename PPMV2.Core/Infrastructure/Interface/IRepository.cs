using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.Interface
{
    public interface IRepository<T> where T:class,new()
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);

    }
}
