namespace DP.Factory;
class BankFactory : IBankFactory
{
    public IBank GetBank(string bankCode)
    {
        switch (bankCode){
            case "123456":return new BankA();
            case "111111":return new BankB();
        }
        return null;
    }

    public IPaymentCard GetPaymentCard(string cardNumber)
    {
        switch (cardNumber){
            case "12":return new VisaCard();
            case "11":return new MasterCard();
        }
        return null;
    }
}