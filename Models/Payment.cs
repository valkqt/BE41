namespace esercizio.Models
{
    public enum PaymentType
    {
        Acconto,
        Stipendio
    }
    public class Payment
    {
        public int id;
        public double amount;
        public PaymentType type;
        public string[] PaymentInterval = new string[2];
        public Employee reference;

        public Payment(int id, double amount, PaymentType type, string[] paymentInterval, Employee reference)
        {
            this.id = id;
            this.amount = amount;
            this.type = type;
            PaymentInterval = paymentInterval;
            this.reference = reference;
        }

    }
}
