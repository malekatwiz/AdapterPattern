namespace AdapterPattern
{
    public interface IPaymentAdapter
    {
        bool MakePayment(int productId);
    }
}
