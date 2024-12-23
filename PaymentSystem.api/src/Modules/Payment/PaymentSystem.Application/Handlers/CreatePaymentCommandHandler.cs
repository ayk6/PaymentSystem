using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using PaymentSystem.Application.Commands;
using PaymentSystem.Domain.Entities;
using PaymentSystem.Domain.Interfaces;

namespace PaymentSystem.Application.Handlers
{
	public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Guid>
	{
		private readonly IPaymentRepository _repository;

		public CreatePaymentCommandHandler(IPaymentRepository repository)
		{
			_repository = repository;
		}

		public async Task<Guid> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
		{
			var payment = new Payment
			{
				Id = Guid.NewGuid(),
				PaymentType = request.PaymentType,
				Amount = request.Amount
			};

			await _repository.AddAsync(payment);
			return payment.Id;
		}
	}
}
