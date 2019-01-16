using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new PaymentClient();

            client.ProcessPayment(1);
            Console.ReadLine();
        }
    }
}
