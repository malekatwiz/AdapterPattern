using System;

namespace AdapterPattern
{
    public class PaymentAdapter : FlexPayment, IPaymentAdapter
    {
        public bool MakePayment(int productId)
        {
            Console.WriteLine($"Here is MakePayment(productId:{productId}) in PaymentAdapter.");
            return base.Pay(GetAccountNumber(), GetPrice(productId));
        }

        private string GetAccountNumber()
        {
            return Guid.NewGuid().ToString();
        }

        private decimal GetPrice(int productId)
        {
            switch (productId)
            {
                case 1:
                    return 100;
                case 2:
                    return 1250;
                case 3:
                    return 5.99M;
            }
            return 0;
        }
    }
}
