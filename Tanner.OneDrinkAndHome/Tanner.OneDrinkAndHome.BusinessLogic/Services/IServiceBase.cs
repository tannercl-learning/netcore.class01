using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tanner.OneDrinkAndHome.BusinessLogic.Services
{
    public interface IServiceBase<T, TDto>
    {
        Task<List<TDto>> GetAllAsync();

        Task<List<TDto>> GetByAsync(Func<T, bool> filter);

        Task<TDto> FirstOrDefaultAsync(Func<T, bool> filter);

        Task<TDto> InsertAsync(TDto entityDto);

        Task UpdateAsync(TDto entityDto);

        Task DeleteAsync(TDto entityDto);

        Task DeleteAsync(long id);
    }
}
