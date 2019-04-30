using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tanner.OneDrinkAndHome.Core.Entities;
using Tanner.OneDrinkAndHome.Core.Model;

namespace Tanner.OneDrinkAndHome.Core.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T: EntityBase
    {
        protected readonly DbSet<T> DbSet;
        protected readonly OneDrikAndHomeContext Context;

        public RepositoryBase(OneDrikAndHomeContext ctx)
        {
            Context = Context ?? ctx;
            DbSet = ctx.Set<T>();
        }

        public async Task DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await Task.CompletedTask;
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await GetByIDAsync(id);
            await DeleteAsync(entity);
        }
        
        public async Task<T> FirstOrDefaultAsync(Func<T, bool> filter)
        {
            var result = DbSet.Where(filter).FirstOrDefault();
            return await Task.FromResult(result);
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetByAsync(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
