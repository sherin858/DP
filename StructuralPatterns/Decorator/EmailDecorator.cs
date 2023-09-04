namespace DP.StructuralPatterns;

public class EmailDecorator:AbstractDecorator
{
    public string SendEmail(string customerId, string sms){
        return $"sms {sms}, sent to {customerId} at {DateTime.Now.ToLongDateString()}";
    }

    public override string SendSMS(string customerId , string mobile , string sms)
    {
        return $"{base.SendSMS(customerId,mobile,sms)}\n{SendEmail(customerId,sms)}";
    }

}
