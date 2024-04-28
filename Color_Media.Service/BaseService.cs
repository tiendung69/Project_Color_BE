using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color_Media.Models;
using Microsoft.EntityFrameworkCore;

namespace Color_Media.Service
{
    public class BaseService<T> : IService<T> where T : class
    {
        public readonly thnd_qlsx_phimContext _context;
        public BaseService(thnd_qlsx_phimContext context)
        {
            _context = context;
           
        }

        public Task<int> Audit(T oldEntity, T newEntity, string email, int type, string action)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<int> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            var result = await _context.SaveChangesAsync();
            return result;
        }

        public virtual Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            var result = _context.SaveChangesAsync();
            return result;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public virtual ValueTask<T> GetObjectAsync(int id)
        {
            return _context.Set<T>().FindAsync(id);
            // throw new NotImplementedException();
        }

        public virtual Task<IQueryable<T>> GetSingleAsync(int id)
        {
            throw new NotImplementedException();
        }

  

        public virtual Task<int> UpdateAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _context.Entry(entity).State = EntityState.Modified;
            var result = _context.SaveChangesAsync();
            return result;
        }

        public Task<int> UpdateAsync(T entity, T newEntity, string email, int type)
        {
            throw new NotImplementedException();
        }
    }
}
