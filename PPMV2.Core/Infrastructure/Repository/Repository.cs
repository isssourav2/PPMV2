using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity,new()
    {
        protected readonly PPMContext _context;
        protected DbSet<T> entity;

        public Repository()
        {
            _context = new PPMContext();
            this.entity= _context.Set<T>();
        }
        

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entity.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var FindResult = await this.entity.FindAsync(id);
            if (FindResult == null)
            {
                throw new ArgumentNullException("FindResult");
            }
            return FindResult;
        }

        public async Task Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.CreatedDate = DateTime.Now;
            this.entity.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.UpdatedDate = DateTime.Now;
            this._context.Entry<T>(entity).State= EntityState.Modified;
            await this._context.SaveChangesAsync();

        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.entity.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
