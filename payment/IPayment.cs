using System;
using System.Collections.Generic;
using System.Text;

namespace payment
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }

    public class Cash : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"The Clint Paid {amount} EGP ");
        }
    }
}
