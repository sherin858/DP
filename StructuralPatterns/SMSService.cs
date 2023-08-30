namespace DP.StructuralPatterns
{
    class SMSService : ISMSService
    {
        public string SendSMS(string customerId, string mobile, string sms)
        {
            return $"CustomerId {customerId} sms sent to {mobile}";
        }
    }
}