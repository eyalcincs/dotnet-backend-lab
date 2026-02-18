using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ticaret
{
    internal class PayPalPayment : PaymentBase, IPaymentMethod
    {
        public string Name => throw new NotImplementedException();

        public void Pay(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ödenecek Tutar 0'dan Büyük Olmalı");
            }
        }

        public override void Process(decimal amount)
        {
            Console.WriteLine("Kapıda Nakit Ödeme İşlemi Başarılı ");
            Console.WriteLine("Ödenen Tutar: " + amount);
        }
    }
}
