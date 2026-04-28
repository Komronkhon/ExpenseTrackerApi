using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Data;

namespace ExpenseTracker.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _entity;

        protected BaseRepository(AppDbContext context)
        {
            _context = context;
            _entity = context.Set<T>();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public virtual async Task<T?> GetById(long id)
        {
            return await _entity.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<T> Create(T entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T?> Update(T entity)
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete(T entity)
        {
            _entity.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}