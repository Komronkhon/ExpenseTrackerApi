using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using System.Xml.Linq;

namespace ExpenseTracker.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
