using DP.Factory;
using DP.StructuralPatterns;
class Program{
    public static void Main(string[] args){
        //Singleton
        // Task task1 = Task.Factory.StartNew(() => {
        //     Counter counter= Counter.GetInstance();
        //     counter.AddOne();
        //     Console.WriteLine(counter.count.ToString());
        // });
        // Task task2 = Task.Factory.StartNew(() => {
        //     Counter counterTwo=Counter.GetInstance();
        //     counterTwo.AddOne();
        //     Console.WriteLine(counterTwo.count.ToString());
        // });
        
        // Counter counter= Counter.GetInstance();
        // Counter counterTwo=Counter.GetInstance();
        // counter.AddOne();
        // counterTwo.AddOne();
        // Console.WriteLine(counter.count.ToString());
        // Console.WriteLine(counterTwo.count.ToString());

        //Factory Method
        // string cardNo,bankCode;
        // Console.WriteLine("Enter card number");
        // cardNo=Console.ReadLine();
        // bankCode=cardNo.Substring(0,6);
        // BankFactory bankFactory=new BankFactory();
        // IBank bank=bankFactory.GetBank(cardCode);
        // Console.WriteLine(bank.Withdraw());



        //Abstract Factory
        // IPaymentCard paymentCard=bankFactory.GetPaymentCard("11");
        // Console.WriteLine(paymentCard.GetName());

        #region proxy
            // SMSServiceProxy proxy = new SMSServiceProxy();
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
        #endregion


        #region decorator
            SMSService smsService = new SMSService();
            EmailDecorator emailDecorator = new EmailDecorator();
            emailDecorator.SetService(smsService);
            Console.WriteLine(emailDecorator.SendSMS("122","0123456789","Hello"));
        #endregion

        Console.ReadKey();
    }
}

