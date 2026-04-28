namespace ExpenseTracker.Services
{
    using AutoMapper;
    using ExpenseTracker.Entities.Models;
    using ExpenseTracker.Repositories.Intetfaces;
    using ExpenseTracker.Services.Intefaces;

    public class BaseService<TEntity, TResponse, TCreateDto> : IBaseService<TResponse, TCreateDto>
        where TEntity : BaseEntity
    {
        protected readonly IBaseRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TResponse>> GetAll()
        {
            var entities = await _repository.GetAll();
            return _mapper.Map<List<TResponse>>(entities);
        }

        public async Task<TResponse?> GetById(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
                return default;

            return _mapper.Map<TResponse>(entity);
        }

        public async Task<TResponse> Create(TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            var created = await _repository.Create(entity);

            return _mapper.Map<TResponse>(created);
        }

        public async Task<TResponse?> Update(int id, TCreateDto dto)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
                return default;

            _mapper.Map(dto, entity);

            var updated = await _repository.Update(entity);

            return _mapper.Map<TResponse>(updated);
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
                return false;

            await _repository.Delete(entity);

            return true;
        }
    }
}
