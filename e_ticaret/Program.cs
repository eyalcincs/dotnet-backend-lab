using e_ticaret;

public class Program
{
    public static void Main(string[] args)
    {
        CreditCardPayment creditCardPayment = new CreditCardPayment();
        PayPalPayment payPayPayment = new PayPalPayment();
        BankTransferPayment bankTransferPayment = new BankTransferPayment();

        creditCardPayment.Pay(-25);
        payPayPayment.Pay(25);
        bankTransferPayment.Process(25);
        creditCardPayment.Process(25);
        Console.WriteLine("Bitti");
    }
}
