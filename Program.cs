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

        //Factory
        string cardNo,cardCode;
        Console.WriteLine("Enter card number");
        cardNo=Console.ReadLine();
        cardCode=cardNo.Substring(0,6);
        BankFactory bankFactory=new BankFactory();
        IBank bank=bankFactory.GetBank(cardCode);
        Console.WriteLine(bank.Withdraw());

        Console.ReadKey();
    }
}

