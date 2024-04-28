using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Media.Service
{
   
        public interface IService<T> : IDisposable, IAsyncDisposable where T : class
        {
            IQueryable<T> GetAll();

            ValueTask<T> GetObjectAsync(int id);

            Task<int> CreateAsync(T entity);

            Task<int> UpdateAsync(T entity);
            Task<int> UpdateAsync(T entity, T newEntity, string email, int type);

            Task<int> DeleteAsync(T entity);

            Task<IQueryable<T>> GetSingleAsync(int id);
            Task<int> Audit(T oldEntity, T newEntity, string email, int type, string action);
        }
    
}
