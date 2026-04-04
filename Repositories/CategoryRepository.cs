using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Intetfaces;
using System.Xml.Linq;

namespace ExpenseTracker.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public Category? Update(int id, Category entity)
        {
            var category = GetById(id);

            if (category == null)
                return null;

            category.Name = entity.Name;
                
            return category;
        }
    }
}
