﻿using Microsoft.EntityFrameworkCore;
using PaymentSystem.Domain.Entities;
using PaymentSystem.Domain.Interfaces;
using PaymentSystem.Persistence.Contexts;

namespace PaymentSystem.Persistence.Repositories
{
	public class PaymentRepository : IPaymentRepository
	{
		private readonly PaymentDbContext _context;

		public PaymentRepository(PaymentDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Payment>> GetAllAsync() => await _context.Payments.ToListAsync();

		public async Task<Payment?> GetByIdAsync(Guid id) => await _context.Payments.FindAsync(id);

		public async Task AddAsync(Payment payment)
		{
			await _context.Payments.AddAsync(payment);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Payment payment)
		{
			_context.Payments.Update(payment);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(Guid id)
		{
			var payment = await _context.Payments.FindAsync(id);
			if (payment != null)
			{
				_context.Payments.Remove(payment);
				await _context.SaveChangesAsync();
			}
		}
	}
}