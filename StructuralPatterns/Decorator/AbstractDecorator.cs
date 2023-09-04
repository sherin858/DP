namespace DP.StructuralPatterns;

public abstract class AbstractDecorator:ISMSService
{
    protected ISMSService smsService;
    public void SetService (ISMSService service){
        smsService = service;
    }
    public override string SendSMS(string customerId , string mobile , string sms){
        if(smsService != null)
        {
            return smsService.SendSMS(customerId,mobile,sms);
        }
        else{
            return "SMSService not initiated";
        }
    }
}