using System.Reflection.Metadata.Ecma335;
using DP.Factory;
using DP.StructuralPatterns;
using DP.StructuralPatterns.Adapter;
using DP.BehaviouralPatterns.Strategy;
class Program{
    public static void Main(string[] args){

        #region Singleton
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
        #endregion

        #region factory
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
        #endregion

        #region proxy
            // SMSServiceProxy proxy = new SMSServiceProxy();
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
            // Console.WriteLine(proxy.SendSMS("123","0123456789","hello"));
        #endregion

        #region decorator
            // SMSService smsService = new SMSService();
            // EmailDecorator emailDecorator = new EmailDecorator();
            // emailDecorator.SetService(smsService);
            // Console.WriteLine(emailDecorator.SendSMS("122","0123456789","Hello"));
        #endregion

        #region Adapter
        // Employee emp = new Employee(){
        //     Name="Sherin",
        //     BasicSalary=1000
        // };
        // MachineOperator oper = new MachineOperator(){
        //     Name="Ali",
        //     BasicSalary=2000,
        //     ShiftCode="shift code"
        // };
        // SalaryCalculator calculator = new SalaryCalculator();
        // SalaryAdapter salaryAdapter = new SalaryAdapter();
        // Console.WriteLine($"{salaryAdapter.CalcSalary(oper)}");
        // Console.WriteLine(calculator.CalcSalary(emp));
        #endregion
        
        #region Strategy
        // NormalDuck normalDuck = new NormalDuck();
        // Console.WriteLine(normalDuck.Fly());
        // normalDuck.SetFlyBehaviour(new FlyWithBox());
        // Console.WriteLine(normalDuck.Fly());
        #endregion
        
        
        Console.ReadKey();
    }
}

