using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace PaymentSystem.Api.GraphQL
{
	public class PaymentSchema : Schema
	{
		public PaymentSchema(IServiceProvider provider) : base(provider)
		{
			Query = provider.GetRequiredService<PaymentQuery>();
			Mutation = provider.GetRequiredService<PaymentMutation>();
		}
	}
}
