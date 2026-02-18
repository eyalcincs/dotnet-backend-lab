using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace e_ticaret
{
    abstract class PaymentBase
    {
   
        public void LogPayment()
        {
            Console.WriteLine("Ödeme işlemi Loglandı");
        }

        public abstract void Process(decimal amount);
    }
}
