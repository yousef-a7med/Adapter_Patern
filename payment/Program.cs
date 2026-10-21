using payment;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Enter money amount");
        decimal amount = decimal.Parse(Console.ReadLine());
        IPayment cash = new Cash();
        cash.Pay(amount);
    }
}