using System;

namespace AdapterPattern
{
    public class FlexPayment
    {
        public bool Pay(string accountNumber, decimal amount)
        {
            Console.WriteLine($"Here is Pay(accountNumber:{accountNumber}, amount:{amount}) method in FlexPayment.");
            return true;
        }
    }
}
