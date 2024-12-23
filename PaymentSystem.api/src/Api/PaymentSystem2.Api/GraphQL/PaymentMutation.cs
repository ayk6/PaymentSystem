using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Resolvers;
using GraphQL.Types;
using MediatR;
using PaymentSystem.Application.Commands;

namespace PaymentSystem.Api.GraphQL
{
	public class PaymentMutation : ObjectGraphType
	{
		public PaymentMutation(IMediator mediator)
		{
			AddField(new FieldType
			{
				Name = "createPayment",
				Arguments = new QueryArguments(
					new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "paymentType" },
					new QueryArgument<NonNullGraphType<DecimalGraphType>> { Name = "amount" }
				),
				Type = typeof(IdGraphType), // Geri dönen tür
				Resolver = new FuncFieldResolver<object>(context =>
				{
					var command = new CreatePaymentCommand
					{
						PaymentType = context.GetArgument<string>("paymentType"),
						Amount = context.GetArgument<decimal>("amount")
					};

					return mediator.Send(command);
				})
			});
		}
	}
}
