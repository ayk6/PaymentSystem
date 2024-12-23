using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Domain.Entities
{
	public class Payment
	{
		public Guid Id { get; set; }
		public string PaymentType { get; set; } = string.Empty;
		public decimal Amount { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}
}
