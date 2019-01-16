using System;

namespace AdapterPattern
{
    public class PaymentClient
    {
        private readonly IPaymentAdapter _paymentAdapter;

        public PaymentClient()
        {
            _paymentAdapter = new PaymentAdapter();
        }
         
        public bool ProcessPayment(int productId)
        {
            Console.WriteLine($"Here is PaymentClient(productId:{productId}) method in PaymentClient.");
            return _paymentAdapter.MakePayment(productId);
        }
    }
}
