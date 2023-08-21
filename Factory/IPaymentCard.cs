namespace DP.Factory
{
    public interface IPaymentCard
    {
        string GetName();
        string GetProviderInfo();
    }

    public class VisaCard : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProviderInfo()
        {
            return "Visa";
        }
    }
}
