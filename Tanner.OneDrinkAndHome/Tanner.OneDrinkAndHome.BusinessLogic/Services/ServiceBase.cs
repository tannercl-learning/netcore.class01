using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanner.OneDrinkAndHome.Core.Repositories;

namespace Tanner.OneDrinkAndHome.BusinessLogic.Services
{
    public class ServiceBase<T, TDto> : IServiceBase<T, TDto>
    {
        protected IRepositoryBase<T> _repository;
        protected IMapper _mapper;

        public ServiceBase(IRepositoryBase<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task DeleteAsync(TDto entityDto)
        {
            var entity = _mapper.Map<T>(entityDto);
            await _repository.DeleteAsync(entity);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<TDto> FirstOrDefaultAsync(Func<T, bool> filter)
        {
            T query = await _repository.FirstOrDefaultAsync(filter);
            TDto result = _mapper.Map<TDto>(query);
            return result;
        }

        public async Task<List<TDto>> GetAllAsync()
        {
            IQueryable<T> query = await _repository.GetAllAsync();
            List<T> list = query.ToList();
            List<TDto> result = _mapper.Map<List<TDto>>(list);
            return result;
        }

        public async Task<List<TDto>> GetByAsync(Func<T, bool> filter)
        {
            IQueryable<T> query = await _repository.GetByAsync(filter);
            List<T> list = query.ToList();
            List<TDto> result = _mapper.Map<List<TDto>>(list);
            return result;
        }

        public async Task<TDto> InsertAsync(TDto entityDto)
        {
            var entity = _mapper.Map<T>(entityDto);
            T insert = await _repository.InsertAsync(entity);
            var result = _mapper.Map<TDto>(insert);
            return result;
        }

        public async Task UpdateAsync(TDto entityDto)
        {
            var entity = _mapper.Map<T>(entityDto);
            await _repository.UpdateAsync(entity);
        }
    }
}
