using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;

namespace ExpenseTracker.Repositories
{
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        public ReportRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}