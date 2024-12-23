using Microsoft.EntityFrameworkCore;
using PaymentSystem.Domain.Entities;

namespace PaymentSystem.Persistence.Contexts
{
	public class PaymentDbContext : DbContext
	{
		public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options) { }

		public DbSet<Payment> Payments { get; set; }
	}
}
