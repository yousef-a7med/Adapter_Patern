using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class VodafoneCash
    {
        public void Transfer(string phone, decimal amount)
        {
            Console.WriteLine($"{phone} Sent {amount} EGP VodafoneCash");
        }
    }

    public class VodafoneCashAdapter : IPayment
    {
        VodafoneCash vch;
        string phone;

        public VodafoneCashAdapter(VodafoneCash vch, string phone)
        {
            this.vch = vch;
            this.phone = phone;
        }

        public void Pay(decimal amount)
        {
            vch.Transfer(phone, amount);
        }
    }
}
