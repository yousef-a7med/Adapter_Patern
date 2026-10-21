using Adapter;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@"
1 => Cash
2 => InstaPay
3 => VodafoneCash ");
        int x = int.Parse(Console.ReadLine());
        decimal amount;
        string phone;
        switch (x)
        {
            case 1:
                Console.WriteLine($"Enter money amount");
                amount = decimal.Parse(Console.ReadLine());
                IPayment cash = new Cash();
                cash.Pay(amount);
                break;

            case 2:
                Console.WriteLine($"Enter phone Num");
                phone = Console.ReadLine();
                Console.WriteLine($"Enter money amount");
                amount = decimal.Parse(Console.ReadLine());
                IPayment insta = new InstaPayAdapter(new InstaPay(), phone);
                insta.Pay(amount);
                break;

            case 3:
                Console.WriteLine($"Enter phone Num");
                phone = Console.ReadLine();
                Console.WriteLine($"Enter money amount");
                amount = decimal.Parse(Console.ReadLine());
                IPayment vodafone = new VodafoneCashAdapter(new VodafoneCash(), phone);
                vodafone.Pay(amount);
                break;

        }
          
    }

   
    
}