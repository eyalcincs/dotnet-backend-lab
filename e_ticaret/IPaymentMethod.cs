using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ticaret
{
    interface IPaymentMethod
    {
        string Name { get; }
        void Pay(decimal amount);
    }
}
