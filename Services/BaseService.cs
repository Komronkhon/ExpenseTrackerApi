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

        public List<TResponse> GetAll()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<List<TResponse>>(entities);
        }

        public TResponse? GetById(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null)
                return default;

            return _mapper.Map<TResponse>(entity);
        }

        public TResponse Create(TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            var created = _repository.Create(entity);

            return _mapper.Map<TResponse>(created);
        }

        public TResponse? Update(int id, TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            var updated = _repository.Update(id, entity);

            if (updated == null)
                return default;

            return _mapper.Map<TResponse>(updated);
        }

        public bool Delete(int id)
        {
            var entity = _repository.GetById(id);

            if (entity == null)
                return false;

            _repository.Delete(entity);

            return true;
        }
    }
}
