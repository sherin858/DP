namespace DP.StructuralPatterns
{
  public class SMSServiceProxy
  {
    private SMSService smsService;
    Dictionary<string,int> customersSMS = new Dictionary<string, int>();
    public string SendSMS(string customerId , string mobile , string sms)
    {
      if(smsService==null){
        smsService = new SMSService();
      }
      if(customersSMS.ContainsKey(customerId)){
        var customerSMSCount = customersSMS.Where(c => c.Key==customerId).FirstOrDefault();
        if(customerSMSCount.Value >= 2){
          return "no more sms";
        }
        customersSMS[customerId] = customerSMSCount.Value + 1 ;
      }
      else{
        customersSMS.Add(customerId,1);
      }
      return smsService.SendSMS(customerId , mobile , sms);
    }
  }
}