namespace DP.Factory;
interface IBankFactory{
    public IBank GetBank(string bankCode);
    public IPaymentCard GetPaymentCard(string cardNumber);
}