﻿using ProvaPub.Models;

namespace ProvaPub.Services
{
	public class OrderService
	{
		public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
		{
			if (paymentMethod == "pix")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "creditcard")
			{
				//Faz pagamento...
			}
			else if (paymentMethod == "paypal")
			{
				//Faz pagamento...
			}

			return await Task.FromResult( new Order()
			{
				Value = paymentValue
			});
		}
	}

    public abstract class NewPayOrder
    {
        public abstract decimal PayOrderNew(decimal paymentValue);
    }

    public class PaymentMethodPix : NewPayOrder
    {
        public override decimal PayOrderNew(decimal paymentValue)
        {
            return 0;
        }
    }
    public class PaymentMethodCreditcard : NewPayOrder
    {
        public override decimal PayOrderNew(decimal paymentValue)
        {
            return 0;
        }
    }

    public class PaymentMethodPaypal : NewPayOrder
    {
        public override decimal PayOrderNew(decimal paymentValue)
        {
            return 0;
        }
    }
}
