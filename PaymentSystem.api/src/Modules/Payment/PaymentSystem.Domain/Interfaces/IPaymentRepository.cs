using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentSystem.Domain.Entities;

namespace PaymentSystem.Domain.Interfaces
{
	public interface IPaymentRepository
	{
		Task<IEnumerable<Payment>> GetAllAsync();
		Task<Payment?> GetByIdAsync(Guid id);
		Task AddAsync(Payment payment);
		Task UpdateAsync(Payment payment);
		Task DeleteAsync(Guid id);
	}
}
