using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
