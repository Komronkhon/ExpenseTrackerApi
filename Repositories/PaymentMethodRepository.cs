using ExpenseTracker.Data;
using ExpenseTracker.Entities.Models;
using ExpenseTracker.Repositories.Interfaces;
using System.Xml.Linq;

namespace ExpenseTracker.Repositories
{
    public class PaymentMethodRepository : BaseRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(AppDbContext context)
            : base(context)
        {
        }
    }
}
