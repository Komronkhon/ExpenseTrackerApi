using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;

namespace ExpenseTracker.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected static readonly List<T> Entities = new List<T>();
        private static long _nextId = 1;

        public virtual List<T> GetAll()
        {
            return Entities;
        }

        public virtual T? GetById(long id)
        {
            return Entities.FirstOrDefault(x => x.Id == id);
        }

        public virtual T Create(T entity)
        {
            entity.Id = _nextId++;
            Entities.Add(entity);
            return entity;
        }

        public virtual T Update(T source, T target)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T entity)
        {
            Entities.Remove(entity);
        }
    }
}
