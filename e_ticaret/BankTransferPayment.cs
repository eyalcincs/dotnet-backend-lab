using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_ticaret
{
    internal class BankTransferPayment : PaymentBase, IPaymentMethod
    {
        public string Name => "CreditCard";

        public void Pay(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ödenecek Tutar 0'dan Büyük Olmalı");
            }
        }

        public override void Process(decimal amount)
        {
            Console.WriteLine("Havale/EFT ile Ödeme İşlemi Başarılı ");
            Console.WriteLine("Ödenen Tutar: " + amount);
        }

    }
}
