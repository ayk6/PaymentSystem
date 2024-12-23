using MediatR;

namespace PaymentSystem.Application.Commands
{
	public class CreatePaymentCommand : IRequest<Guid>
	{
		public string PaymentType { get; set; } = string.Empty;
		public decimal Amount { get; set; }
	}
}
