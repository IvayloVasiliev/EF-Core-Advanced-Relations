namespace BillsPaymentSystem.Models
{
    public class BankAccount
    {
        //o BankAccountId
        //o Balance
        //o BankName(up to 50 characters, unicode)
        //o SWIFT Code(up to 20 characters, non-unicode)

        public int BankAccountId { get; set; }

        public decimal Balance { get; set; }

        public string BankName { get; set; }

        public string SWIFTCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
