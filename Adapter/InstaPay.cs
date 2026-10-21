using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class InstaPay
    {
        public void Transfer(string phone, decimal amount)
        {
            Console.WriteLine($"{phone} Sent {amount} EGP Instapay");
        }
    }

    public class InstaPayAdapter : IPayment
    {
        InstaPay ip;
        string phone;

        public InstaPayAdapter(InstaPay ip, string phone)
        {
            this.ip = ip;
            this.phone = phone;
        }

        public void Pay(decimal amount)
        {
            ip.Transfer(phone, amount);
        }
    }
}
