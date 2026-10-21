using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    enum PaymentType
    {
        Cash,
        InstaPay,
        VodafoneCash,
    }
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
