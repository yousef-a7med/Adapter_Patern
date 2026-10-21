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
                if(x==1)
                    Console.WriteLine( $"{PaymentType.Cash}");
                Console.WriteLine($"Enter money amount");
                amount = decimal.Parse(Console.ReadLine());
                IPayment cash = new Cash();
                cash.Pay(amount);
                break;

            case 2:
                if (x == 2)
                    Console.WriteLine($"{PaymentType.InstaPay}");
                Console.WriteLine($"Enter phone Num");
                phone = Console.ReadLine();
                Console.WriteLine($"Enter money amount");
                amount = decimal.Parse(Console.ReadLine());
                IPayment insta = new InstaPayAdapter(new InstaPay(), phone);
                insta.Pay(amount);
                break;

            case 3:
                if (x == 3)
                    Console.WriteLine($"{PaymentType.VodafoneCash}");
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