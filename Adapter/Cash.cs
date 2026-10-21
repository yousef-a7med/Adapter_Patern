using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Cash : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"The Clint Paid {amount} EGP " );
        }
    }
}
