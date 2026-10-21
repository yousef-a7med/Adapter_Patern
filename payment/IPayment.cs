using System;
using System.Collections.Generic;
using System.Text;

namespace payment
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
