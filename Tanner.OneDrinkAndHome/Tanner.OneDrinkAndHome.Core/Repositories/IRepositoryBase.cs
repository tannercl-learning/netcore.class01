using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanner.OneDrinkAndHome.Core.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> GetAllAsync();

        Task<IQueryable<T>> GetByAsync(Func<T, bool> filter);

        Task<T> FirstOrDefaultAsync(Func<T, bool> filter);

        Task<T> GetByIDAsync(long id);

        Task<T> InsertAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task DeleteAsync(long entityID);
    }
}
