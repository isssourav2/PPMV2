using PPMV2.Core.Infrastructure.Interface;
using PPMV2.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.UserRepo
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> GetAll();

        Task<User> GetById(int id);

        Task Add(User entity);

        Task Update(User entity);

        Task Delete(User entity);
    }
}
