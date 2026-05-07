using ExpenseTracker.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        { }

        public DbSet<Expense> Expences { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasOne(e => e.Category)
                    .WithMany(c => c.Expenses)
                    .HasForeignKey(e => e.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.User)
                    .WithMany(u => u.Expenses)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.PaymentMethod)
                    .WithMany(p => p.Expenses)
                    .HasForeignKey(e => e.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasOne(i => i.User)
                    .WithMany(u => u.Incomes)
                    .HasForeignKey(i => i.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasOne(r => r.User)
                    .WithMany(u => u.Reports)
                    .HasForeignKey(r => r.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasData(
                    new User { Id = 1, Name = "Admin", Email = "admin@mail.com", CreatedAt = DateTime.Parse("2020-10-10") }
                );
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasData(
                    new Category { Id = 1, Name = "Food", CreatedAt = DateTime.Parse("2020-10-10") },
                    new Category { Id = 2, Name = "Transport", CreatedAt = DateTime.Parse("2020-10-10") },
                    new Category { Id = 3, Name = "Shopping", CreatedAt = DateTime.Parse("2020-10-10") }
                );
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasData(
                    new PaymentMethod { Id = 1, Name = "Cash", CreatedAt = DateTime.Parse("2020-10-10") },
                    new PaymentMethod { Id = 2, Name = "Card", CreatedAt = DateTime.Parse("2020-10-10") },
                    new PaymentMethod { Id = 3, Name = "Transfer", CreatedAt = DateTime.Parse("2020-10-10") },
                    new PaymentMethod { Id = 4, Name = "Wallet", CreatedAt = DateTime.Parse("2020-10-10") }
                );
            });
        }
    }
}